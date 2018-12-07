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


namespace WebTickets.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {

        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }



        // GET: User
        public ActionResult Index()
        {
            var model = _userService.GetAll();

            return View(model);
        }
        /*
        public async Task<ActionResult> Get(string id)
        {
            var model = await _userManager.FindByIdAsync(id);
            ViewBag.Roles = _roleManager.Roles.OrderBy(x => x.Name).ToList();

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
        */
    }
}