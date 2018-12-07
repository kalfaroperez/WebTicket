using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Model.Auth;
//using NLog;
using Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Auth.Service
{
    // Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        private static ILogger<ApplicationUser> logger;
        private readonly IUserStore<ApplicationUser> _store;

        public ApplicationUserManager(IUserStore<ApplicationUser> store, 
            IOptions<IdentityOptions> optionsAccessor, 
            IPasswordHasher<ApplicationUser> passwordHasher, 
            IEnumerable<IUserValidator<ApplicationUser>> userValidators, 
            IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, 
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            IServiceProvider services, 
            ILogger<UserManager<ApplicationUser>> logger) 
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            _store = store;
        }

        public async override Task<IdentityResult> AddToRoleAsync(ApplicationUser user, string roleId)
        {
            try
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var userId = user.Id;
                    ctx.ApplicationUserRole.Add(new ApplicationUserRole
                    {
                        UserId = userId,
                        RoleId = roleId
                    });

                    ctx.SaveChanges();
                }

                return await Task.FromResult(IdentityResult.Success);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return await Task.FromResult(IdentityResult.Failed());
            }
        }

        public async new Task<IEnumerable<ApplicationRole>> GetRolesAsync(string userId)
        {
            IEnumerable<ApplicationRole> result = new List<ApplicationRole>();

            try
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var roles = ctx.ApplicationUserRole.Where(x => x.UserId == userId).Select(x => x.RoleId).ToList();
                    result = ctx.ApplicationRole.Where(x => roles.Contains(x.Id)).OrderBy(x => x.Name).ToList();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }

            return await Task.FromResult(result);
        }

        public async override Task<bool> IsInRoleAsync(ApplicationUser user, string roleId)
        {
            var result = false;

            try
            {
                using (var ctx = new ApplicationDbContext())
                {
                    result = ctx.ApplicationUserRole.Any(x => x.UserId == user.Id && x.RoleId == roleId);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }

            return await Task.FromResult(result);
        }

        public async override Task<IdentityResult> RemoveFromRoleAsync(ApplicationUser user, string roleId)
        {
            try
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var roles = ctx.ApplicationUserRole.Where(x => x.RoleId == roleId && x.UserId == user.Id).ToList();
                    ctx.Entry(roles).State = EntityState.Deleted;

                    ctx.SaveChanges();
                }

                return await Task.FromResult(IdentityResult.Success);
            }
            catch (Exception ex)
            {
                logger.LogError     (ex.Message);
                return await Task.FromResult(IdentityResult.Failed());
            }
        }
        
    }
}