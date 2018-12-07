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
    public class RegistroEquipoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistroEquipoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RegistroEquipo
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistroEquipo.ToListAsync());
        }

        // GET: RegistroEquipo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroEquipo = await _context.RegistroEquipo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroEquipo == null)
            {
                return NotFound();
            }

            return View(registroEquipo);
        }

        // GET: RegistroEquipo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistroEquipo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPlanta,NombrePlanta,IdEquipoPrinc,NombreEquipoPrinc,IdEquipoSec,NombreEquipoSec,IdComponente,NombreComponente")] RegistroEquipo registroEquipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroEquipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroEquipo);
        }

        // GET: RegistroEquipo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroEquipo = await _context.RegistroEquipo.FindAsync(id);
            if (registroEquipo == null)
            {
                return NotFound();
            }
            return View(registroEquipo);
        }

        // POST: RegistroEquipo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPlanta,NombrePlanta,IdEquipoPrinc,NombreEquipoPrinc,IdEquipoSec,NombreEquipoSec,IdComponente,NombreComponente")] RegistroEquipo registroEquipo)
        {
            if (id != registroEquipo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroEquipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroEquipoExists(registroEquipo.Id))
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
            return View(registroEquipo);
        }

        // GET: RegistroEquipo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroEquipo = await _context.RegistroEquipo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroEquipo == null)
            {
                return NotFound();
            }

            return View(registroEquipo);
        }

        // POST: RegistroEquipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registroEquipo = await _context.RegistroEquipo.FindAsync(id);
            _context.RegistroEquipo.Remove(registroEquipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroEquipoExists(int id)
        {
            return _context.RegistroEquipo.Any(e => e.Id == id);
        }
    }
}
