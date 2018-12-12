using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Common;
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
using static WebTickets.Helpers.FileHelpers;

namespace WebTickets.Controllers
{
    public class EquipoPrincipalController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ILogger<EquipoPrincipalController> _logger;
        private readonly IFileProvider _fileProvider;
        private const string _Administrador = "Administrador";
        private const string _Operador = "Operador";
        private const string path_Ficha_tec = "Ficha_tec_";

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
                        await ProcessFormFile(formFile, ModelState);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                EquipoPrincipal ep = new EquipoPrincipal
                {
                    Nombre = equipoPrincipal.Nombre,
                    Descripcion = equipoPrincipal.Descripcion,
                    Estado = equipoPrincipal.Estado,
                    Insert_Oper = "Insert",
                    Update_Oper = "",
                    Insert_Datetime = DateTime.Now,
                    Update_Datetime = DateTime.Now
                };

                _context.Add(ep);
                await _context.SaveChangesAsync();
                //Una vez guardo el registro, Tomo el ID y lo envio para crear la carpeta 
                //con el nombre del ID y guardar el Adjunto.
                await UploadFiles(
                    equipoPrincipal.FileUpload,
                    path_Ficha_tec + ep.Id.ToString(),
                    Enum.GetName(typeof(PathUploapFile), PathUploapFile.Fichas_tecnicas));

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
            EquiposPrincipalViewModel equipoPrin = new EquiposPrincipalViewModel
            {
                Nombre = ep.Nombre,
                Descripcion = ep.Descripcion,
                Estado = ep.Estado
            };
            GetFilesByIdEquipo(path_Ficha_tec + id, equipoPrin);
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
                        await ProcessFormFile(formFile, ModelState);
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
                    await UploadFiles(
                        equipoPrincipal.FileUpload,
                        path_Ficha_tec + ep.Id,
                        Enum.GetName(typeof(PathUploapFile), PathUploapFile.Fichas_tecnicas));
                    
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

        public void GetFilesByIdEquipo(string id_elememto, EquiposPrincipalViewModel ep)
        {
            string path = FileHelpers.GetPathFile_FichaTecnica();            
            string pathSource = string.Format("{0}\\{1}", path, id_elememto);
            bool existe_ruta = Directory.Exists(pathSource);
            
            if (existe_ruta)
            {
                foreach (var item in Directory.GetFiles(pathSource))
                {
                    ep.Files.Add(new FileDetails {
                        Name = Path.GetFileName(item),
                        Path = pathSource,
                        Fecha_modificacion = System.IO.File.GetLastWriteTime(item)
                    });
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
            return File(memory, GetContentType(filename), Path.GetFileName(filename));
        }

    }
}
