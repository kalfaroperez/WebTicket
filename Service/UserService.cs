using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Model.Custom;
using Persistence.DatabaseContext;

namespace Service
{
    public interface IUserService
    {
        IEnumerable<UserForGridView> GetAll();
    }

    public class UserService : IUserService
    {

        private ILogger<UserService> logger;
        private readonly ApplicationDbContext _context;
        //private readonly IRepository<ApplicationUser> _applicationUserRepo;

        public UserService(
            ApplicationDbContext context            
        )
        {
            _context = context;
            //_applicationUserRepo = applicationUserRepo;
        }
        public IEnumerable<UserForGridView> GetAll()
        {
            var result = new List<UserForGridView>();

            try
            {
               result =  _context.ApplicationUser.ToList()
                    .Select(u => new UserForGridView {
                        Id = u.Id,
                        UserName = u.UserName,
                        Email  = u.Email
                    }).ToList();
            }
            catch (Exception e)
            {
                logger.LogError(e.Message);
            }

            return result;
        }
    }
}
