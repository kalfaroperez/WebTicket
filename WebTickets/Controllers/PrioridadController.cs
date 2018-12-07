using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Model.DB_Model;
using Persistence.DatabaseContext;

namespace WebTickets.Controllers
{
    public class PrioridadController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrioridadController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prioridad
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prioridad.ToListAsync());
        }

        // GET: Prioridad/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prioridad = await _context.Prioridad
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prioridad == null)
            {
                return NotFound();
            }

            return View(prioridad);
        }

        // GET: Prioridad/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prioridad/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre_Prioridad")] Prioridad prioridad)
        {
            if (ModelState.IsValid)
            {
                prioridad.Fecha_Insercion = DateTime.Now;
                prioridad.Fecha_Modificacion = DateTime.Now;
                _context.Add(prioridad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prioridad);
        }

        // GET: Prioridad/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prioridad = await _context.Prioridad.FindAsync(id);
            if (prioridad == null)
            {
                return NotFound();
            }
            return View(prioridad);
        }

        // POST: Prioridad/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre_Prioridad")] Prioridad prioridad)
        {
            if (id != prioridad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    prioridad.Fecha_Insercion = DateTime.Now;
                    prioridad.Fecha_Modificacion = DateTime.Now;
                    _context.Update(prioridad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrioridadExists(prioridad.Id))
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
            return View(prioridad);
        }

        // GET: Prioridad/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prioridad = await _context.Prioridad
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prioridad == null)
            {
                return NotFound();
            }

            return View(prioridad);
        }

        // POST: Prioridad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prioridad = await _context.Prioridad.FindAsync(id);
            _context.Prioridad.Remove(prioridad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrioridadExists(int id)
        {
            return _context.Prioridad.Any(e => e.Id == id);
        }
    }
}
