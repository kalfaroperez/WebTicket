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
    public class CalificacionServicioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalificacionServicioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CalificacionServicio
        public async Task<IActionResult> Index()
        {
            return View(await _context.CalificacionServicio.ToListAsync());
        }

        // GET: CalificacionServicio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacionServicio = await _context.CalificacionServicio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calificacionServicio == null)
            {
                return NotFound();
            }

            return View(calificacionServicio);
        }

        // GET: CalificacionServicio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CalificacionServicio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] CalificacionServicio calificacionServicio)
        {
            if (ModelState.IsValid)
            {
                calificacionServicio.FechaInsercion = DateTime.Now;
                calificacionServicio.FechaModificacion = DateTime.Now;
                _context.Add(calificacionServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calificacionServicio);
        }

        // GET: CalificacionServicio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacionServicio = await _context.CalificacionServicio.FindAsync(id);
            if (calificacionServicio == null)
            {
                return NotFound();
            }
            return View(calificacionServicio);
        }

        // POST: CalificacionServicio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] CalificacionServicio calificacionServicio)
        {
            if (id != calificacionServicio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    calificacionServicio.FechaInsercion = DateTime.Now;
                    calificacionServicio.FechaModificacion = DateTime.Now;
                    _context.Update(calificacionServicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalificacionServicioExists(calificacionServicio.Id))
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
            return View(calificacionServicio);
        }

        // GET: CalificacionServicio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacionServicio = await _context.CalificacionServicio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calificacionServicio == null)
            {
                return NotFound();
            }

            return View(calificacionServicio);
        }

        // POST: CalificacionServicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calificacionServicio = await _context.CalificacionServicio.FindAsync(id);
            _context.CalificacionServicio.Remove(calificacionServicio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalificacionServicioExists(int id)
        {
            return _context.CalificacionServicio.Any(e => e.Id == id);
        }
    }
}
