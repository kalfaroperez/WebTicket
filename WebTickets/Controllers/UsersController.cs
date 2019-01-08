using Auth.Service;
using Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Auth;
using Service;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Persistence.DatabaseContext;

namespace WebTickets.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {

        private readonly IUserService _userService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public UsersController(
            IUserService userService, 
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _userService = userService;
            _userManager = userManager;
            _context = context;
        }



        // GET: User
        public ActionResult Index()
        {
            var model = _userService.GetAll();

            return View(model);
        }
        
        public async Task<ActionResult> Get(string id)
        {
            var model = await _userManager.FindByIdAsync(id);
            ViewBag.Roles = _context.UserRoles.Where(x=> x.UserId == id).ToList();
            
            return View(model);
        }

        public async Task<ActionResult> AddRole(ApplicationUser user,ApplicationUserRole role)
        {
            if (!_userManager.IsInRoleAsync(user, role.RoleId).Result)
            {
                var result = await _userManager.AddToRoleAsync(user, role.RoleId);

                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.ToString());
                }
            }

            return RedirectToAction("Index");
        }
        
    }
}