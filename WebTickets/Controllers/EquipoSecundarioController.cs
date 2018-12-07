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
    public class EquipoSecundarioController : Controller
    {      

        private readonly ApplicationDbContext _context;
        private ILogger<EquipoSecundarioController> _logger;
        private const string _Administrador = "Administrador";
        private const string _Operador = "Operador";

        public EquipoSecundarioController(
            ApplicationDbContext context,
            ILogger<EquipoSecundarioController> logger)
        {
            _logger = logger;
            _context = context;
        }

        // GET: EquipoSecundario
        public async Task<IActionResult> Index()
        {

            var result = new List<EquiposCommonListViewModel>();
            try
            {
                var lista = await _context.EquipoSecundario.ToListAsync();
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

        // GET: EquipoSecundario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipoSecundario = await _context.EquipoSecundario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipoSecundario == null)
            {
                return NotFound();
            }

            return View(equipoSecundario);
        }

        // GET: EquipoSecundario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EquipoSecundario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Estado")] EquipoSecundario equipoSecundario)
        {
            if (ModelState.IsValid)
            {
                equipoSecundario.Insert_Oper = "Inset";
                equipoSecundario.Update_Oper = "";
                equipoSecundario.Insert_Datetime = DateTime.Now;
                equipoSecundario.Update_Datetime = DateTime.Now;
                _context.Add(equipoSecundario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipoSecundario);
        }

        // GET: EquipoSecundario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipoSecundario = await _context.EquipoSecundario.FindAsync(id);
            if (equipoSecundario == null)
            {
                return NotFound();
            }
            return View(equipoSecundario);
        }

        // POST: EquipoSecundario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Estado")] EquipoSecundario equipoSecundario)
        {
            if (id != equipoSecundario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    equipoSecundario.Update_Oper = "Update";
                    equipoSecundario.Update_Datetime = DateTime.Now;
                    _context.Update(equipoSecundario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipoSecundarioExists(equipoSecundario.Id))
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
            return View(equipoSecundario);
        }

        // GET: EquipoSecundario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipoSecundario = await _context.EquipoSecundario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipoSecundario == null)
            {
                return NotFound();
            }

            return View(equipoSecundario);
        }

        // POST: EquipoSecundario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipoSecundario = await _context.EquipoSecundario.FindAsync(id);
            _context.EquipoSecundario.Remove(equipoSecundario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipoSecundarioExists(int id)
        {
            return _context.EquipoSecundario.Any(e => e.Id == id);
        }
    }
}
