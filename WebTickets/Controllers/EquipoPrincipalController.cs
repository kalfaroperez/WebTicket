using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Model.DB_Model;
using Persistence.DatabaseContext;
using WebTickets.Helpers;
using WebTickets.ViewModels;

namespace WebTickets.Controllers
{
    public class EquipoPrincipalController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ILogger<EquipoPrincipalController> _logger;
        private readonly IFileProvider _fileProvider;
        private const string _Administrador = "Administrador";
        private const string _Operador = "Operador";

        public EquipoPrincipalController(
            ApplicationDbContext context,
            ILogger<EquipoPrincipalController> logger,
            IFileProvider fileProvider)
        {
            _logger = logger;
            _context = context;
            _fileProvider = fileProvider;
        }

        // GET: EquipoPrincipal
        public async Task<IActionResult> Index()
        {
            var result = new List<EquiposCommonListViewModel>();
            try
            {
                var lista = await _context.EquipoPrincipal.ToListAsync();
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

        // GET: EquipoPrincipal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipoPrincipal = await _context.EquipoPrincipal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipoPrincipal == null)
            {
                return NotFound();
            }

            return View(equipoPrincipal);
        }

        // GET: EquipoPrincipal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EquipoPrincipal/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequestSizeLimit(10485760)]
        public async Task<IActionResult> Create(EquiposPrincipalViewModel equipoPrincipal)
        {
            if (equipoPrincipal != null)
            {
                if (equipoPrincipal.FileUpload != null)
                {
                    foreach (var formFile in equipoPrincipal.FileUpload)
                    {
                        await FileHelpers.ProcessFormFile(formFile, ModelState);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                EquipoPrincipal ep = new EquipoPrincipal();
                ep.Nombre = equipoPrincipal.Nombre;
                ep.Descripcion = equipoPrincipal.Descripcion;
                ep.Estado = equipoPrincipal.Estado;
                ep.Insert_Oper = "Insert";
                ep.Update_Oper = "";
                ep.Insert_Datetime = DateTime.Now;
                ep.Update_Datetime = DateTime.Now;

                _context.Add(ep);
                await _context.SaveChangesAsync();
                //Una vez guardo el registro, Tomo el ID y lo envio para crear la carpeta 
                //con el nombre del ID y guardar el Adjunto.
                await UploadFiles(equipoPrincipal.FileUpload, ep.Id);

                return RedirectToAction(nameof(Index));
            }
            return View(equipoPrincipal);
        }

        // GET: EquipoPrincipal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ep = await _context.EquipoPrincipal.FindAsync(id);
            if (ep == null)
            {
                return NotFound();
            }
            EquiposPrincipalViewModel equipoPrin = new EquiposPrincipalViewModel();
            equipoPrin.Nombre = ep.Nombre;
            equipoPrin.Descripcion = ep.Descripcion;
            equipoPrin.Estado = ep.Estado;
            GetFilesByIdEquipo(id, equipoPrin);
            return View(equipoPrin);
        }

        // POST: EquipoPrincipal/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequestSizeLimit(10485760)]
        public async Task<IActionResult> Edit(int id, EquiposPrincipalViewModel equipoPrincipal)
        {
            if (id != equipoPrincipal.Id)
            {
                return NotFound();
            }

            if (equipoPrincipal != null)
            {
                if (equipoPrincipal.FileUpload != null)
                {
                    foreach (var formFile in equipoPrincipal.FileUpload)
                    {
                        await FileHelpers.ProcessFormFile(formFile, ModelState);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    //EquipoPrincipal ep = new EquipoPrincipal();
                    var ep = await _context.EquipoPrincipal.FindAsync(id);
                    ep.Nombre = equipoPrincipal.Nombre;
                    ep.Descripcion = equipoPrincipal.Descripcion;
                    ep.Estado = equipoPrincipal.Estado;
                    ep.Update_Oper = "Update";
                    ep.Insert_Oper = "";
                    ep.Update_Datetime = DateTime.Now;
                    _context.Update(ep);
                    await _context.SaveChangesAsync();
                    //Una vez guardo el registro, Tomo el ID y lo envio para crear la carpeta 
                    //con el nombre del ID y guardar el Adjunto.
                    await UploadFiles(equipoPrincipal.FileUpload, equipoPrincipal.Id);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipoPrincipalExists(equipoPrincipal.Id))
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
            return View(equipoPrincipal);
        }

        // GET: EquipoPrincipal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipoPrincipal = await _context.EquipoPrincipal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipoPrincipal == null)
            {
                return NotFound();
            }

            return View(equipoPrincipal);
        }

        // POST: EquipoPrincipal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipoPrincipal = await _context.EquipoPrincipal.FindAsync(id);
            _context.EquipoPrincipal.Remove(equipoPrincipal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipoPrincipalExists(int id)
        {
            return _context.EquipoPrincipal.Any(e => e.Id == id);
        }

        public async Task<IActionResult> UploadFiles(List<IFormFile> files, int id_equipo)
        {
            if (files != null)
            {
                if (files.Count > 0 && id_equipo != 0)
                {
                    string path = FileHelpers.GetPathFile_FichaTecnica();
                    Directory.CreateDirectory(string.Format("{0}\\{1}", path, id_equipo.ToString()));
                    // full path to file in temp location
                    var filePath = string.Format("{0}\\{1}", path, id_equipo);

                    foreach (var formFile in files)
                    {
                        if (formFile.Length > 0)
                        {

                            var filePathURL = Path.Combine(filePath, formFile.FileName);
                            using (var stream = new FileStream(filePathURL, FileMode.Create))
                            {
                                await formFile.CopyToAsync(stream);
                            }
                        }
                    }

                }
            }
            return Ok(new { ok = "ok"});
        }

        public void GetFilesByIdEquipo(int? id_equipo, EquiposPrincipalViewModel ep)
        {
            string path = FileHelpers.GetPathFile_FichaTecnica();            
            string pathSource = string.Format("{0}\\{1}", path, id_equipo.ToString());
            bool existe_ruta = Directory.Exists(pathSource);
            
            if (existe_ruta)
            {
                foreach (var item in Directory.GetFiles(pathSource))
                {
                    ep.Files.Add(new FileDetails { Name = item, Path = pathSource });
                }
                
            }
        }

        public async Task<IActionResult> Download(string filename, EquiposPrincipalViewModel ep)
        {
            if (filename == null)
                return Content("filename not present");

            var memory = new MemoryStream();
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, FileHelpers.GetContentType(filename), Path.GetFileName(filename));
        }
        
    }
}
