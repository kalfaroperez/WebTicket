using Auth.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Auth;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Controllers
{
    [Authorize]
    public class RolesController : Controller
    {
        private readonly ApplicationRoleManager _roleManager;
        // GET: User
        public ActionResult Index()
        {
            var model = _roleManager.Roles.OrderBy(x => x.Name).ToList();

            return View(model);
        }

        public async Task<ActionResult> Add(ApplicationRole model)
        {
            var response = await _roleManager.CreateAsync(model);

            if (!response.Succeeded)
            {
                throw new Exception(response.Errors.ToString());
            }

            return RedirectToAction("Index");
        }
    }
}