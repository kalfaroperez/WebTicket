using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Model.Auth;
using Model.DB_Model;
using Persistence.DatabaseContext;
using WebTickets.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Service;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.FileProviders;
using Model.Custom;

namespace WebTickets
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
       
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<IFileProvider>(
                new PhysicalFileProvider("D:\\uploads\\"));

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders(); 

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                //options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IEmailConfiguration>(Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());
            // Add application services.
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IEmailService, EmailService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Account",
                    template: "{controller=Account}/{action=Login}/{id?}");
            });
            loggerFactory.AddProvider(new NLoggerProvider());
            SeedDataUserAdmin.SeedData(app.ApplicationServices, Configuration);
            
        }

        public class NLoggerProvider : ILogger, ILoggerProvider
        {
            private NLog.Logger logger;

            public void Dispose()
            {
            }

            private NLog.LogLevel GetNLogLevel(LogLevel logLevel)
            {
                switch (logLevel)
                {
                    case LogLevel.Critical: return NLog.LogLevel.Fatal;
                    case LogLevel.Debug: return NLog.LogLevel.Debug;
                    case LogLevel.Error: return NLog.LogLevel.Error;
                    case LogLevel.Information: return NLog.LogLevel.Info;
                    case LogLevel.Trace: return NLog.LogLevel.Trace;
                    case LogLevel.Warning: return NLog.LogLevel.Warn;
                    default: return NLog.LogLevel.Off;
                }
            }

            void ILogger.Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                if (logger != null)
                {
                    var nlogLevel = GetNLogLevel(logLevel);
                    string logText = formatter(state, exception);
                    logger.Log(nlogLevel, logText);
                }
            }

            bool ILogger.IsEnabled(LogLevel logLevel)
            {
                if (logger == null)
                {
                    return false;
                }
                var nlogLevel = GetNLogLevel(logLevel);
                return logger.IsEnabled(nlogLevel);
            }

            IDisposable ILogger.BeginScope<TState>(TState state)
            {
                return null;
            }

            ILogger ILoggerProvider.CreateLogger(string categoryName)
            {
                try
                {
                    NLoggerProvider logger = new NLoggerProvider
                    {
                        logger = NLog.LogManager.GetCurrentClassLogger()
                    };
                    return logger;
                }
                catch
                {
                    // return new ConsoleLogger(); // you must implement this
                    return null;
                }
            }
        }
    }
}
