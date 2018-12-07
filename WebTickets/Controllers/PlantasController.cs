using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model.DB_Model;
using WebTickets.ViewModels;
using Persistence.DatabaseContext;
using WebTickets.Helpers;
using NLog;

namespace WebTickets.Controllers
{
    public class PlantasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ILogger<PlantasController> _logger;
        private const string _Administrador = "Administrador";
        private const string _Operador = "Operador";

        public PlantasController(
            ApplicationDbContext context,
            ILogger<PlantasController> logger)
        {
            _logger = logger;
            _context = context;
        }

        // GET: Plantas
        //[Authorize(Roles = _Administrador)]
        [Authorize(Roles = _Administrador)]
        public async Task<IActionResult> Index()
        {
            var result = new List<EquiposCommonListViewModel>();
            try
            {

                var plantas = await _context.Planta.ToListAsync();
                result = plantas.Select(x => new EquiposCommonListViewModel
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Descripcion = x.Descripcion,
                    Estado = x.Estado
                }).ToList();

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }


            return View(result);
        }

        // GET: Plantas/Details/5
        [Authorize(Roles = _Administrador)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planta = await _context.Planta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planta == null)
            {
                return NotFound();
            }

            return View(planta);
        }

        // GET: Plantas/Create
        [Authorize(Roles = _Administrador)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plantas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = _Administrador)]
        public async Task<IActionResult> Create(PlantaViewModel planta)
        {
            if (ModelState.IsValid)
            {
                Planta p = new Planta();
                p.Nombre = planta.Nombre;
                p.Descripcion = planta.Descripcion;
                p.Estado = planta.Estado;
                p.Insert_Oper = "Inset";
                p.Update_Oper = "";
                p.Insert_Datetime = DateTime.Now;
                p.Update_Datetime = DateTime.Now;

                _context.Add(p);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planta);
        }

        // GET: Plantas/Edit/5
        [Authorize(Roles = _Administrador)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planta = await _context.Planta.FindAsync(id);
                        
            if (planta == null)
            {
                return NotFound();
            }
            PlantaViewModel p = new PlantaViewModel();
            p.Id = planta.Id;
            p.Nombre = planta.Nombre;
            p.Descripcion = planta.Descripcion;
            p.Estado = planta.Estado;
            
            return View(p);
        }

        // POST: Plantas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = _Administrador)]
        public async Task<IActionResult> Edit(int id, PlantaViewModel p)
        {
            if (id != p.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Planta planta = new Planta();
                    planta.Nombre = p.Nombre;
                    planta.Descripcion = p.Descripcion;
                    planta.Estado = p.Estado;
                    planta.Insert_Oper = "";
                    planta.Update_Oper = "Update";
                    planta.Insert_Datetime = DateTime.Now;
                    planta.Update_Datetime = DateTime.Now;
                    _context.Update(planta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlantaExists(p.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(p);
        }

        // GET: Plantas/Delete/5
        [Authorize(Roles = _Administrador)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planta = await _context.Planta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planta == null)
            {
                return NotFound();
            }

            return View(planta);
        }

        // POST: Plantas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = _Administrador)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planta = await _context.Planta.FindAsync(id);
            _context.Planta.Remove(planta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlantaExists(int id)
        {
            return _context.Planta.Any(e => e.Id == id);
        }
    }
}
