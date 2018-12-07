﻿using System;
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
    public class ProcesosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProcesosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Procesos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Procesos.ToListAsync());
        }

        // GET: Procesos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procesos = await _context.Procesos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procesos == null)
            {
                return NotFound();
            }

            return View(procesos);
        }

        // GET: Procesos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Procesos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre_Proceso")] Procesos procesos)
        {
            if (ModelState.IsValid)
            {
                procesos.Fecha_Insercion = DateTime.Now;
                procesos.Fecha_Modificacion = DateTime.Now;
                _context.Add(procesos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(procesos);
        }

        // GET: Procesos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procesos = await _context.Procesos.FindAsync(id);
            if (procesos == null)
            {
                return NotFound();
            }
            return View(procesos);
        }

        // POST: Procesos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre_Proceso")] Procesos procesos)
        {
            if (id != procesos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    procesos.Fecha_Insercion = DateTime.Now;
                    procesos.Fecha_Modificacion = DateTime.Now;
                    _context.Update(procesos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcesosExists(procesos.Id))
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
            return View(procesos);
        }

        // GET: Procesos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var procesos = await _context.Procesos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procesos == null)
            {
                return NotFound();
            }

            return View(procesos);
        }

        // POST: Procesos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var procesos = await _context.Procesos.FindAsync(id);
            _context.Procesos.Remove(procesos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcesosExists(int id)
        {
            return _context.Procesos.Any(e => e.Id == id);
        }
    }
}
