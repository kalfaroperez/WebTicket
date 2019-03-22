using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.Auth;
using Model.DB_Model;
using Persistence.DatabaseContext;
using WebTickets.ViewModels;

namespace WebTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;

        public HomeController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILoggerFactory loggerFactory,
            ApplicationDbContext context)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = loggerFactory.CreateLogger<HomeController>();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var query = from ti in _context.Ticket
                        join user in _context.ApplicationUser on ti.Usuario_Id equals user.Id
                        join est in _context.EstadoServicio on ti.Estado equals est.Id
                        group new { est.Nombre } by ti.Id into grupo
                        select new
                        {
                            Estado = grupo.Key,
                            Conteo = grupo.Count()
                        };

            foreach (var item in query)
            {
                string text = string.Format("{0} - {1}", item.Conteo , item.Estado);
            }
            InformePorEstado i = new InformePorEstado();

            return View();
        }

        [HttpGet]
        public IActionResult Index_()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
