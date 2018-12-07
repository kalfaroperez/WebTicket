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
    public class TipoTrabajoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoTrabajoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TipoTrabajo
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoTrabajo.ToListAsync());
        }

        // GET: TipoTrabajo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTrabajo = await _context.TipoTrabajo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoTrabajo == null)
            {
                return NotFound();
            }

            return View(tipoTrabajo);
        }

        // GET: TipoTrabajo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoTrabajo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Estado")] TipoTrabajo tipoTrabajo)
        {
            if (ModelState.IsValid)
            {
                tipoTrabajo.Fecha_Insercion = DateTime.Now;
                tipoTrabajo.Fecha_Modificacion = DateTime.Now;
                _context.Add(tipoTrabajo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoTrabajo);
        }

        // GET: TipoTrabajo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTrabajo = await _context.TipoTrabajo.FindAsync(id);
            if (tipoTrabajo == null)
            {
                return NotFound();
            }
            return View(tipoTrabajo);
        }

        // POST: TipoTrabajo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Estado")] TipoTrabajo tipoTrabajo)
        {
            if (id != tipoTrabajo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tipoTrabajo.Fecha_Insercion = DateTime.Now;
                    tipoTrabajo.Fecha_Modificacion = DateTime.Now;
                    _context.Update(tipoTrabajo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoTrabajoExists(tipoTrabajo.Id))
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
            return View(tipoTrabajo);
        }

        // GET: TipoTrabajo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTrabajo = await _context.TipoTrabajo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoTrabajo == null)
            {
                return NotFound();
            }

            return View(tipoTrabajo);
        }

        // POST: TipoTrabajo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoTrabajo = await _context.TipoTrabajo.FindAsync(id);
            _context.TipoTrabajo.Remove(tipoTrabajo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoTrabajoExists(int id)
        {
            return _context.TipoTrabajo.Any(e => e.Id == id);
        }
    }
}
