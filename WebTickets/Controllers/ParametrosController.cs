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
    public class ParametrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParametrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Parametros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parametros.ToListAsync());
        }

        // GET: Parametros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametros = await _context.Parametros
                .FirstOrDefaultAsync(m => m.ParametrosId == id);
            if (parametros == null)
            {
                return NotFound();
            }

            return View(parametros);
        }

        // GET: Parametros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parametros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParametrosId,ValidezPsw,DiasPsw,MaxLinesScreen,MaxLinesExport,MaxDifMin,MaxAttach,AssignTicket,FromUserRequest,SubcarpetaAdjuntoTicket,SubcarpetaAdjuntoFichaTec,FromUserPsw,ContactDefault,ProcessDefault,StateDefault,StateAlert,MainScreenState,DateFormat,Pen,Pas,Can")] Parametros parametros)
        {
            if (ModelState.IsValid)
            {
                parametros.InsertOper = "Insert";
                parametros.UpdateOper = "";
                parametros.InsertDatetime = DateTime.Now;
                parametros.UpdateDatetime = DateTime.Now;
                _context.Add(parametros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parametros);
        }

        // GET: Parametros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametros = await _context.Parametros.FindAsync(id);
            if (parametros == null)
            {
                return NotFound();
            }
            return View(parametros);
        }

        // POST: Parametros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParametrosId,ValidezPsw,DiasPsw,MaxLinesScreen,MaxLinesExport,MaxDifMin,MaxAttach,AssignTicket,FromUserRequest,SubcarpetaAdjuntoTicket,SubcarpetaAdjuntoFichaTec,FromUserPsw,ContactDefault,ProcessDefault,StateDefault,StateAlert,MainScreenState,DateFormat,Pen,Pas,Can")] Parametros parametros)
        {
            if (id != parametros.ParametrosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    parametros.UpdateOper = "Update";
                    parametros.UpdateDatetime = DateTime.Now;
                    _context.Update(parametros);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParametrosExists(parametros.ParametrosId))
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
            return View(parametros);
        }

        // GET: Parametros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametros = await _context.Parametros
                .FirstOrDefaultAsync(m => m.ParametrosId == id);
            if (parametros == null)
            {
                return NotFound();
            }

            return View(parametros);
        }

        // POST: Parametros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parametros = await _context.Parametros.FindAsync(id);
            _context.Parametros.Remove(parametros);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParametrosExists(int id)
        {
            return _context.Parametros.Any(e => e.ParametrosId == id);
        }
    }
}
