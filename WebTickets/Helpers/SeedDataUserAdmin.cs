using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Model.Auth;
using Microsoft.AspNetCore.Builder;
using Persistence.DatabaseContext;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebTickets.Helpers
{
    public static class SeedDataUserAdmin
    {
        public static void SeedData(IServiceProvider serviceProvider, IConfiguration Configuration)
        {
            SeedRoles(serviceProvider).Wait();
            SeedUsers(serviceProvider, Configuration).Wait();
        }

        private static async Task SeedUsers(IServiceProvider serviceProvider, IConfiguration Configuration)
        {
            using (var app = serviceProvider.CreateScope())
            {
                var _context = app.ServiceProvider.GetService<ApplicationDbContext>();
                UserManager<ApplicationUser> userManager = app.ServiceProvider.GetService<UserManager<ApplicationUser>>();
                
                //creating a super user who could maintain the web app
                var poweruser = new ApplicationUser
                {
                    UserName = Configuration.GetSection("AppSettings")["UserName"],
                    NormalizedEmail = (Configuration.GetSection("AppSettings")["Email"]).ToUpper(),
                    NormalizedUserName = (Configuration.GetSection("AppSettings")["UserName"]).ToUpper(),
                    Email = Configuration.GetSection("AppSettings")["Email"],
                    FullName = Configuration.GetSection("AppSettings")["FullName"],
                    Area = Convert.ToInt32(Configuration.GetSection("AppSettings")["Area"]),
                    Ubicacion = Configuration.GetSection("AppSettings")["Ubicacion"],
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                string userPassword = Configuration.GetSection("AppSettings")["UserPassword"];
                
                if (!_context.Users.Any(u => u.NormalizedUserName == poweruser.NormalizedUserName))
                {
                    var password = new PasswordHasher<ApplicationUser>();
                    var hashed = password.HashPassword(poweruser, userPassword);
                    poweruser.PasswordHash = hashed;
                    var userStore = new UserStore<ApplicationUser>(_context);
                    var createPowerUser = await userStore.CreateAsync(poweruser);
                    if (createPowerUser.Succeeded)
                    {
                        IdentityRole rol = _context.Roles.FirstOrDefault(r => r.Name == "Administrador");
                        //here we tie the new user to the "Administrador" rol                                                
                        if (rol.Name == "Administrador")
                        {
                            await userManager.AddToRoleAsync(poweruser, rol.Name);
                        }
                        

                    }
                }
                await _context.SaveChangesAsync();
            }
        }

        private static async Task SeedRoles(IServiceProvider serviceProvider)
        {
            using (var app = serviceProvider.CreateScope())
            {
                var context = app.ServiceProvider.GetService<ApplicationDbContext>();
                Role[] roles = (Role[])Enum.GetValues(typeof(Role));
                foreach (var r in roles)
                {
                    // Create an identity role object out of the enum value
                    var roleName = r.GetRoleName();
                    var roleManager = new RoleStore<IdentityRole>(context);
                    // Create the role if it doesn't already exist
                    if (!roleManager.Roles.Any(rol => rol.Name == roleName))
                    {
                        var rolStructure = new IdentityRole()
                        {
                            Name = roleName,
                            NormalizedName = roleName.ToUpper()
                        };
                        var result = await roleManager.CreateAsync(rolStructure);
                        if (!result.Succeeded)
                        {
                            // FIXME: Do not throw an Exception object
                            throw new Exception("Creating role failed");
                        }
                        await context.SaveChangesAsync();

                    }
                }
            }
        }
    }
}
