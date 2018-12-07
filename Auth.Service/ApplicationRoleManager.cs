using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Owin;
using Microsoft.Extensions.Logging;
using Model.Auth;
using Persistence.DatabaseContext;

namespace Auth.Service
{
    public class ApplicationRoleManager : RoleManager<ApplicationRole>
    {
        
        private readonly IRoleStore<ApplicationRole> _store;
        public ApplicationRoleManager(
            IRoleStore<ApplicationRole> store, 
            IEnumerable<IRoleValidator<ApplicationRole>> roleValidators, 
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            ILogger<RoleManager<ApplicationRole>> logger) 
            : base(store, roleValidators, keyNormalizer, errors, logger)
        {
            _store = store;
        }

       
    }
}
