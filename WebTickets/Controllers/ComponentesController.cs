using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model.DB_Model;
using Persistence.DatabaseContext;
using WebTickets.ViewModels;

namespace WebTickets.Controllers
{
    public class ComponentesController : Controller
    {

        private readonly ApplicationDbContext _context;
        private ILogger<ComponentesController> _logger;
        private const string _Administrador = "Administrador";
        private const string _Operador = "Operador";

        public ComponentesController(
            ApplicationDbContext context,
            ILogger<ComponentesController> logger)
        {
            _logger = logger;
            _context = context;
        }

        // GET: Componentes
        public async Task<IActionResult> Index()
        {
            var result = new List<EquiposCommonListViewModel>();
            try
            {
                var lista = await _context.Componentes.ToListAsync();
                result = lista.Select(x => new EquiposCommonListViewModel
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

        // GET: Componentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var componentes = await _context.Componentes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (componentes == null)
            {
                return NotFound();
            }

            return View(componentes);
        }

        // GET: Componentes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Componentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Estado")] Componentes componentes)
        {
            if (ModelState.IsValid)
            {
                componentes.Insert_Oper = "Inset";
                componentes.Update_Oper = "";
                componentes.Insert_Datetime = DateTime.Now;
                componentes.Update_Datetime = DateTime.Now;
                _context.Add(componentes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(componentes);
        }

        // GET: Componentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var componentes = await _context.Componentes.FindAsync(id);
            if (componentes == null)
            {
                return NotFound();
            }
            return View(componentes);
        }

        // POST: Componentes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Estado")] Componentes componentes)
        {
            if (id != componentes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    componentes.Update_Oper = "Update";
                    componentes.Update_Datetime = DateTime.Now;
                    _context.Update(componentes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComponentesExists(componentes.Id))
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
            return View(componentes);
        }

        // GET: Componentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var componentes = await _context.Componentes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (componentes == null)
            {
                return NotFound();
            }

            return View(componentes);
        }

        // POST: Componentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var componentes = await _context.Componentes.FindAsync(id);
            _context.Componentes.Remove(componentes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComponentesExists(int id)
        {
            return _context.Componentes.Any(e => e.Id == id);
        }
    }
}
