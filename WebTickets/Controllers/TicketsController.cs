using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Model.Auth;
using Model.DB_Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Persistence.DatabaseContext;
using WebTickets.Helpers;
using WebTickets.ViewModels;
using PagedList;
using static WebTickets.Helpers.FileHelpers;

namespace WebTickets.Controllers
{
    //Ok
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IFileProvider _fileProvider;
        private readonly ILogger _logger;

        //Esta variable me servirá como bandera para confirmar si la peticion tuvo exito o no
        private static bool exito = false;
        private static string ticket_numero;

        public TicketsController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILoggerFactory loggerFactory,
            IFileProvider fileProvider,
            ApplicationDbContext context)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = loggerFactory.CreateLogger<TicketsController>();
            _fileProvider = fileProvider;

        }

        // GET: Tickets
        public async Task<IActionResult> Index(int? page)
        {

            var result = new List<TicketListViewModel>();
            try
            {

                var lista = await _context.Ticket.AsNoTracking().ToListAsync();
                result = lista.Select(x => new TicketListViewModel
                {
                    Id = x.Id.ToString(),
                    Numero_Ticket = x.Numero_Ticket,
                    Username = _context.ApplicationUser.Find(x.Usuario_Id).UserName,
                    Operador_Nombre_Completo = _context.ApplicationUser.Find(x.Usuario_Id).FullName,
                    Prioridad = _context.Prioridad.Find(x.Prioridad).Nombre_Prioridad,
                    Asignado_A = _context.ApplicationUser.Find(x.Asignado_A).UserName,
                    Fecha = x.Fecha,
                    Fecha_Entrega = x.Fecha_Entrega,
                    EstadoServicio = _context.EstadoServicio.Find(x.Estado).Nombre,
                }).ToList();

            }
            catch (Exception e)
            {

                _logger.LogError(e.Message);
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(result);
        }

        // GET: Tickets
        [HttpPost]
        public IActionResult Lista()
        {

            var result = new List<TicketListViewModel>();
            try
            {

                var lista = _context.Ticket.AsNoTracking().ToList();
                result = lista.Select(x => new TicketListViewModel
                {
                    Id = x.Id.ToString(),
                    Numero_Ticket = x.Numero_Ticket,
                    Username = _context.ApplicationUser.Find(x.Usuario_Id).UserName,
                    Operador_Nombre_Completo = _context.ApplicationUser.Find(x.Usuario_Id).FullName,
                    Prioridad = _context.Prioridad.Find(x.Prioridad).Nombre_Prioridad,
                    Asignado_A = _context.ApplicationUser.Find(x.Asignado_A).UserName,
                    Fecha = x.Fecha,
                    Fecha_Entrega = x.Fecha_Entrega,
                    EstadoServicio = _context.EstadoServicio.Find(x.Estado).Nombre,
                }).ToList();

            }
            catch (Exception e)
            {

                _logger.LogError(e.Message);
            }

            return Json(result);
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            TicketViewModel tvm = new TicketViewModel();
            CargarFormulario_Tickets(tvm);
            if (exito)
            {
                ViewBag.Resultado = string.Format("Su Ticket {0} ha sido registrado con exito!!", ticket_numero);
                exito = false;
                ticket_numero = "";
            }
            return View(tvm);
        }


        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TicketViewModel tvm)
        {
            if (tvm != null)
            {
                if (tvm.FileUpload != null)
                {
                    foreach (var formFile in tvm.FileUpload)
                    {
                        await ProcessFormFile(formFile, ModelState);
                    }
                }
            }
            if (ModelState.IsValid)
            {
                Ticket ticket = Fill_TicketModel(tvm);
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                //Una vez guardo el registro, Tomo el ID y lo envio para crear la carpeta 
                //con el nombre del ID y guardar el Adjunto.
                await UploadFiles(
                    tvm.FileUpload,
                    ticket.Numero_Ticket,
                    Enum.GetName(typeof(PathUploapFile), PathUploapFile.Tickets));

                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Comentarios",
                    ValorActual = ticket.Comentarios
                };
                _context.SigoTicket.Add(sigoTicket);
                await _context.SaveChangesAsync();
                exito = true;
                ticket_numero = ticket.Numero_Ticket;
                return RedirectToAction(nameof(Create), ViewBag.Resultado);
            }
            CargarFormulario_Tickets(tvm);
            return View(tvm);
        }



        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            TicketViewModel tvm = CargarFormulario_Tickets(ticket);
            GetFilesByIdTicket(tvm.Numero_Ticket, tvm);
            return View(tvm);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ulong id, TicketViewModel tvm)
        {
            if (id != tvm.Id)
            {
                return NotFound();
            }
            if (tvm != null)
            {
                if (tvm.FileUpload != null)
                {
                    foreach (var formFile in tvm.FileUpload)
                    {
                        await ProcessFormFile(formFile, ModelState);
                    }
                }
            }
            if (ModelState.IsValid)
            {

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {

                        InsertSeguimientoTicket(tvm);
                        //Ticket Comparer Compara los cambios
                        Ticket ticket = Fill_TicketModel(tvm);
                        _context.Update(ticket);
                        await _context.SaveChangesAsync();

                        //Una vez guardo el registro, Tomo el ID y lo envio para crear la carpeta 
                        //con el nombre del ID y guardar el Adjunto.
                        await UploadFiles(
                            tvm.FileUpload,
                            ticket.Numero_Ticket,
                            Enum.GetName(typeof(PathUploapFile), PathUploapFile.Tickets));

                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {


                        tvm.Error = "No se ha podido guardar el registro. Ha ocurrido un error <br/>"
                                            + ex.Message + "<br/> " + ex.InnerException;
                        return View(tvm);
                    }

                }

                return RedirectToAction(nameof(Index));
            }
            CargarFormulario_Tickets(tvm);
            return View(tvm);
        }

        private List<string> InsertSeguimientoTicket(TicketViewModel tvm)
        {
            List<string> camposCambiados = new List<string>();
            var ticket = _context.Ticket.AsNoTracking().FirstOrDefault(t => t.Id == tvm.Id);
            var cambioNumeroSeg = _context.SigoTicket.AsNoTracking().Where(s => s.SeqTicketId == Convert.ToInt32(tvm.Id)).GroupBy(s => s.CambioNumero).Count();
            cambioNumeroSeg = cambioNumeroSeg + 1;

            //Comparare los campos de la bd con los de 
            //la aplicacion para saber cual fue actualizado.
            if (!string.IsNullOrEmpty(tvm.NotasTrabajo))
            {
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "NotasTrabajo",
                    CambioNumero = cambioNumeroSeg,
                    NotasTrabajo = tvm.NotasTrabajo,
                    ValorActual = tvm.NotasTrabajo,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }

            if (ticket.Operador_Id != tvm.Operador_Id)
            {
                camposCambiados.Add("Operador");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Operador",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.ApplicationUser.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Operador_Id).FullName,
                    ValorActual = _context.ApplicationUser.AsNoTracking().SingleOrDefault(t => t.Id == tvm.Operador_Id).FullName,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Area_Id != tvm.Area_Id)
            {
                camposCambiados.Add("Area");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Area",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.Planta.AsNoTracking().SingleOrDefault(a => a.Id == ticket.Area_Id).Nombre,
                    ValorActual = _context.Planta.AsNoTracking().SingleOrDefault(a => a.Id == tvm.Area_Id).Nombre,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Prioridad != tvm.Prioridad)
            {
                camposCambiados.Add("Prioridad");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Prioridad",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.Prioridad.AsNoTracking().SingleOrDefault(p => p.Id == ticket.Prioridad).Nombre_Prioridad,
                    ValorActual = _context.Prioridad.AsNoTracking().SingleOrDefault(p => p.Id == tvm.Prioridad).Nombre_Prioridad,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Proceso != tvm.Proceso)
            {
                camposCambiados.Add("Proceso");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Proceso",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.Procesos.AsNoTracking().SingleOrDefault(p => p.Id == ticket.Proceso).Nombre_Proceso,
                    ValorActual = _context.Procesos.AsNoTracking().SingleOrDefault(p => p.Id == tvm.Proceso).Nombre_Proceso,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Asignado_A != tvm.Asignado_A)
            {
                camposCambiados.Add("Asignado_A");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Asignado_A",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.ApplicationUser.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Asignado_A).FullName,
                    ValorActual = _context.ApplicationUser.AsNoTracking().SingleOrDefault(t => t.Id == tvm.Asignado_A).FullName,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Tipo_Trabajo != tvm.Tipo_Trabajo)
            {
                camposCambiados.Add("Tipo_Trabajo");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Tipo_Trabajo",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.TipoTrabajo.AsNoTracking().SingleOrDefault(tt => tt.Id == ticket.Tipo_Trabajo).Nombre,
                    ValorActual = _context.TipoTrabajo.AsNoTracking().SingleOrDefault(tt => tt.Id == tvm.Tipo_Trabajo).Nombre,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Id_Planta != tvm.Planta)
            {
                camposCambiados.Add("Planta");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Planta",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.Planta.AsNoTracking().SingleOrDefault(p => p.Id == ticket.Id_Planta).Nombre,
                    ValorActual = _context.Planta.AsNoTracking().SingleOrDefault(p => p.Id == tvm.Planta).Nombre,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Id_EquipoPrinc != tvm.EquipoPrincipal)
            {
                camposCambiados.Add("EquipoPrincipal");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "EquipoPrincipal",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.EquipoPrincipal.AsNoTracking().SingleOrDefault(ep => ep.Id == ticket.Id_EquipoPrinc).Nombre,
                    ValorActual = _context.EquipoPrincipal.AsNoTracking().SingleOrDefault(ep => ep.Id == tvm.EquipoPrincipal).Nombre,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Id_EquipoSec != tvm.EquipoSecundario)
            {
                camposCambiados.Add("EquipoSecundario");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "EquipoSecundario",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.EquipoSecundario.AsNoTracking().SingleOrDefault(es => es.Id == ticket.Id_EquipoSec).Nombre,
                    ValorActual = _context.EquipoSecundario.AsNoTracking().SingleOrDefault(es => es.Id == tvm.EquipoSecundario).Nombre,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Id_Componente != tvm.Componente)
            {
                camposCambiados.Add("Componente");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Componente",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.Componentes.AsNoTracking().SingleOrDefault(c => c.Id == ticket.Id_Componente).Nombre,
                    ValorActual = _context.Componentes.AsNoTracking().SingleOrDefault(c => c.Id == tvm.Componente).Nombre,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Estado != tvm.Estado)
            {
                camposCambiados.Add("Estado");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "EstadoServicio",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = _context.EstadoServicio.AsNoTracking().FirstOrDefault(es => es.Id == ticket.Estado).Nombre,
                    ValorActual = _context.EstadoServicio.AsNoTracking().FirstOrDefault(es => es.Id == tvm.Estado).Nombre,
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            if (ticket.Fecha_Entrega != tvm.Fecha_Entrega)
            {
                camposCambiados.Add("Fecha_Entrega");
                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = Convert.ToInt32(ticket.Id),
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Fecha_Entrega",
                    CambioNumero = cambioNumeroSeg,
                    ValorAnterior = ticket.Fecha_Entrega.ToString(),
                    ValorActual = tvm.Fecha_Entrega.ToString(),
                    InsertDatetime = DateTime.Now
                };
                _context.SigoTicket.Add(sigoTicket);
                _context.SaveChanges();
            }
            return camposCambiados;
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ulong id)
        {
            var ticket = await _context.Ticket.FindAsync(id);
            _context.Ticket.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(ulong? id)
        {
            return _context.Ticket.Any(e => e.Id == id);
        }

        [HttpPost]
        public IActionResult GetUsuario([FromBody]UsuarioViewModel usuario)
        {

            UsuarioViewModel uvm = new UsuarioViewModel();
            var item = _context.ApplicationUser.Find(usuario.Id);
            if (item == null)
            {
                return NotFound();
            }

            uvm.Id = item.Id;
            uvm.Nombre_completo = item.FullName;
            uvm.UserName = item.UserName;

            if (item.Area != 0)
            {
                var area = _context.Area.Find(item.Area);
                uvm.Area_Id = area.Id;
                uvm.Area = area.Nombre;
            }
            uvm.Ubicacion = item.Ubicacion;
            uvm.Email = item.Email;
            uvm.Telefono = item.Telefono;

            return Json(uvm);
        }

        public void GetFilesByIdTicket(string id_elememto, TicketViewModel ti)
        {
            string path = FileHelpers.GetPathFile_Ticket();
            string pathSource = string.Format("{0}\\{1}", path, id_elememto);
            bool existe_ruta = Directory.Exists(pathSource);

            if (existe_ruta)
            {
                foreach (var item in Directory.GetFiles(pathSource))
                {

                    ti.Files.Add(new FileDetails
                    {
                        Name = Path.GetFileName(item),
                        Path = pathSource,
                        Fecha_modificacion = System.IO.File.GetLastWriteTime(item)
                    });
                }

            }
        }

        public async Task<IActionResult> Download(string filename)
        {
            if (filename == null)
                return Content("filename not present");

            string[] param = filename.Split("---");
            string numero_ticket = param[0];
            string _filename = param[1];
            string path_file = string.Format("{0}\\{1}\\{2}",
                GetPathFile_Ticket(),
                numero_ticket,
                _filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path_file, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path_file), Path.GetFileName(path_file));
        }

        #region Helpers

        private static Ticket Fill_TicketModel(TicketViewModel tvm)
        {

            Ticket ticket = new Ticket
            {
                Numero_Ticket = tvm.Numero_Ticket,
                Usuario_Id = tvm.Usuario_Id,
                Operador_Id = tvm.Operador_Id,
                Fecha = DateTime.Now,
                Nombre_completo = tvm.Operador_Nombre_completo,
                Area_Id = tvm.Area_Id,
                Ubicacion = tvm.Ubicacion,
                Telefono = tvm.Telefono,
                EMail = tvm.Email,
                Asignado_A = tvm.Asignado_A,
                Prioridad = tvm.Prioridad,
                Incidente = tvm.Incidente,
                Comentarios = tvm.Comentarios,
                Proceso = tvm.Proceso,
                Tipo_Trabajo = tvm.Tipo_Trabajo,
                Id_Planta = tvm.Planta,
                Id_EquipoPrinc = tvm.EquipoPrincipal,
                Id_EquipoSec = tvm.EquipoSecundario,
                Id_Componente = tvm.Componente,
                Estado = tvm.Estado,
                Calificacion = tvm.Calificacion,
                Fecha_Entrega = tvm.Fecha_Entrega,
                Fecha_Ultimo_Estado = DateTime.Now,
                Insert_Datetime = DateTime.Now,
                Update_Datetime = DateTime.Now
            };
            if (tvm.Id.ToString() != null)
            {
                ticket.Id = tvm.Id;
            }
            return ticket;
        }

        private TicketViewModel CargarFormulario_Tickets(TicketViewModel tvm)
        {
            //Consulto El Id del usuario en Session
            string user_id = _userManager.GetUserId(User);
            var user = _context.ApplicationUser.Find(user_id);
            tvm.Username = _userManager.GetUserName(User);

            //Usuario que creara el ticket
            tvm.Usuario_Id = user_id;

            tvm.Nombre_completo = user.FullName;

            //Ahora Procedo a cargar los Selectores del Formulario
            string numero = "";
            var ticket = _context.Ticket.LastOrDefault();
            if (ticket == null)
            {
                numero = string.Format("REQ{0}00{1}", DateTime.Now.Year, 1);
            }
            else
            {
                numero = string.Format("REQ{0}00{1}", DateTime.Now.Year, ticket.Id + 1);
            }
            //Numero Ticket Consecutivo
            tvm.Numero_Ticket = numero;

            //Selector Prioridades
            tvm.Lista_Prioridades = GetPrioridades();

            //Selector Procesos
            tvm.Lista_Procesos = GetProcesos();

            //Selector Asignados_A
            tvm.Lista_Asignados_A = Get_Lista_Asignado_A();

            //Selector Tipo Trabajos
            tvm.Lista_Tipo_Trabajos = Get_Tipo_Trabajos();

            //Selector Plantas
            tvm.Lista_Plantas = Get_Plantas();

            //Selector Equipos_princ
            tvm.Lista_Equipos_princ = Get_Equipos_principales();

            //Selector Equipos_sec
            tvm.Lista_Equipos_sec = Get_Equipos_Secundarios();

            //Selector Componentes
            tvm.Lista_Componentes = Get_Componentes();

            //Selector Componentes
            tvm.Lista_Estados = Get_Estados_Servicio();
            return tvm;
        }

        private TicketViewModel CargarFormulario_Tickets(Ticket ticket)
        {
            TicketViewModel tvm = new TicketViewModel();
            //Consulto El Id del usuario en Session
            string user_id = _userManager.GetUserId(User);
            var user = _context.ApplicationUser.Find(user_id);
            tvm.Username = _userManager.GetUserName(User);

            //Usuario que creara el ticket
            tvm.Usuario_Id = user_id;

            tvm.Id = ticket.Id;
            //Numero Ticket Consecutivo
            tvm.Numero_Ticket = ticket.Numero_Ticket;
            tvm.Fecha = ticket.Fecha;
            tvm.Nombre_completo = user.FullName;

            //Datos Operador
            tvm.Operador_Id = ticket.Operador_Id;
            var operador = _context.ApplicationUser.Find(ticket.Operador_Id);
            //Ahora Procedo a cargar los Selectores del Formulario
            tvm.Operador_Nombre_completo = operador.FullName;
            tvm.Operador_UserName = operador.UserName;
            tvm.Email = operador.Email;
            tvm.Area_Id = operador.Area;
            tvm.Area = _context.Area.Find(operador.Area).Nombre;
            tvm.Ubicacion = operador.Ubicacion;

            tvm.Incidente = ticket.Incidente;
            tvm.Comentarios = ticket.Comentarios;

            //Selector Prioridades
            tvm.Lista_Prioridades = GetPrioridades();
            tvm.Prioridad = ticket.Prioridad;

            //Selector Procesos
            tvm.Lista_Procesos = GetProcesos();
            tvm.Proceso = ticket.Proceso;

            //Selector Asignados_A
            tvm.Lista_Asignados_A = Get_Lista_Asignado_A();
            tvm.Asignado_A = ticket.Asignado_A;

            //Selector Tipo Trabajos
            tvm.Lista_Tipo_Trabajos = Get_Tipo_Trabajos();
            tvm.Tipo_Trabajo = ticket.Tipo_Trabajo;

            //Selector Plantas
            tvm.Lista_Plantas = Get_Plantas();
            tvm.Planta = ticket.Id_Planta;

            //Selector Equipos_princ
            tvm.Lista_Equipos_princ = Get_Equipos_principales();
            tvm.EquipoPrincipal = ticket.Id_EquipoPrinc;

            //Selector Equipos_sec
            tvm.Lista_Equipos_sec = Get_Equipos_Secundarios();
            tvm.EquipoSecundario = ticket.Id_EquipoSec;

            //Selector Componentes
            tvm.Lista_Componentes = Get_Componentes();
            tvm.Componente = ticket.Id_Componente;

            //Selector Estados
            tvm.Lista_Estados = Get_Estados_Servicio();
            tvm.Estado = ticket.Estado;

            tvm.Fecha_Entrega = ticket.Fecha_Entrega;
            tvm.Fecha_Ultimo_Estado = ticket.Fecha_Ultimo_Estado;

            return tvm;
        }

        [HttpPost]
        public IActionResult GetUsuarios()
        {
            var usuarios = _context.ApplicationUser.ToList();
            return Json(usuarios);
        }

        [HttpPost]
        public IActionResult  GetSeguimientoTicket_NG([FromBody]SigoTicketViewModel sigo)
        {

            List<SeguimientoViewModel> lista_seg = new List<SeguimientoViewModel>();
            var id_ticket = sigo.Id;

            var cambios = from st in _context.SigoTicket
                          join us in _context.ApplicationUser on st.UsuarioId equals us.Id
                          where st.SeqTicketId == Convert.ToInt32(id_ticket)
                          group new {st.Fecha, us.FullName, st.CambioNumero }  by st.CambioNumero into stGr
                          select new {
                              cambioNumero = stGr.Key,
                              cantidadCambios = stGr.Count()
                          };

            List<SeguimientoViewModel> seguimientos = new List<SeguimientoViewModel>();
            //Cantidad de Cambios
            foreach (var cambio in cambios)
            {
                //Cambio sobre un unico campo que no sea nota de trabajo
                var lista_cambios = _context.SigoTicket.Where(s => s.CambioNumero == cambio.cambioNumero && s.SeqTicketId == Convert.ToInt32(id_ticket)).ToList();
                if (cambio.cantidadCambios == 1)
                {
                    SeguimientoViewModel seg = new SeguimientoViewModel();
                    foreach (var item in lista_cambios)
                    {
                        seg.CambioNumero = cambio.cambioNumero;
                        seg.Fecha = item.Fecha;
                        seg.UsuarioId = _context.ApplicationUser.First(s => s.Id == item.UsuarioId).FullName;

                        var operador = _context.ApplicationUser.First(s => s.Id == item.OperadorId).FullName;
                        SigoTicketViewModel stvm = new SigoTicketViewModel
                        {
                            Id = item.SeqSigoTicketId.ToString(),
                            OperadorId = operador,
                            NotasTrabajo = item.NotasTrabajo,
                            ValorActual = item.ValorActual,
                            ValorAnterior = item.ValorAnterior,
                            Visible = item.Visible,
                            Fecha = item.Fecha,
                            Comentario = item.Comentario,
                            NombreAdjunto = item.NombreAdjunto,
                            TipoAdjunto = item.TipoAdjunto,
                            CampoCambiado = item.CampoCambiado,
                            InsertDatetime = item.InsertDatetime
                        };
                        seg.Cambios.Add(stvm);
                    }
                    seguimientos.Add(seg);
                }

                //Cambios realizados en una misma fecha y hora sobre un ticket
                if (cambio.cantidadCambios > 1)
                {
                    SeguimientoViewModel seg = new SeguimientoViewModel();
                    foreach (var item in lista_cambios)
                    {
                        seg.CambioNumero = cambio.cambioNumero;
                        seg.Fecha = item.Fecha;
                        seg.UsuarioId = _context.ApplicationUser.First(s => s.Id == item.UsuarioId).FullName;

                        var operador = _context.ApplicationUser.First(s => s.Id == item.OperadorId).FullName;
                        SigoTicketViewModel stvm = new SigoTicketViewModel
                        {
                            Id = item.SeqSigoTicketId.ToString(),
                            OperadorId = operador,
                            NotasTrabajo = item.NotasTrabajo,
                            ValorActual = item.ValorActual,
                            ValorAnterior = item.ValorAnterior,
                            Visible = item.Visible,
                            Fecha = item.Fecha,
                            Comentario = item.Comentario,
                            NombreAdjunto = item.NombreAdjunto,
                            TipoAdjunto = item.TipoAdjunto,
                            CampoCambiado = item.CampoCambiado,
                            InsertDatetime = item.InsertDatetime
                        };
                        seg.Cambios.Add(stvm);
                    }
                    seguimientos.Add(seg);
                }
            }
            
            return Json(seguimientos);
        }

        private List<SigoTicket> Get_SeguimientoTicket()
        {
            var lista = _context.SigoTicket.ToList();
            return lista;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Prioridad"
        /// </summary>
        /// <returns>Devuelve la Lista de Prioridades para ser cargadas en un selector</returns>
        private List<SelectListItem> GetPrioridades()
        {
            var prioridades = _context.Prioridad.ToList();
            List<SelectListItem> lista_prioridades = new List<SelectListItem>();
            RegisterViewModel rvm = new RegisterViewModel();
            foreach (var item in prioridades)
            {
                lista_prioridades.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre_Prioridad)
                    });

            }

            return lista_prioridades;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Procesos"
        /// </summary>
        /// <returns>Devuelve la Lista de Procesos para ser cargadas en un selector</returns>
        private List<SelectListItem> GetProcesos()
        {
            var procesos = _context.Procesos.ToList();
            List<SelectListItem> lista_procesos = new List<SelectListItem>();
            RegisterViewModel rvm = new RegisterViewModel();
            foreach (var item in procesos)
            {
                lista_procesos.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre_Proceso)
                    });

            }

            return lista_procesos;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Tipo_Trabajo"
        /// </summary>
        /// <returns>Devuelve la Lista de Tipos de Trabajo para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Tipo_Trabajos()
        {
            var tipoTrabajos = _context.TipoTrabajo.ToList();
            List<SelectListItem> lista_tipo_trabajos = new List<SelectListItem>();
            RegisterViewModel rvm = new RegisterViewModel();
            foreach (var item in tipoTrabajos)
            {
                lista_tipo_trabajos.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre)
                    });

            }

            return lista_tipo_trabajos;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Asignado_A"
        /// </summary>
        /// <returns>Devuelve la Lista de Asignado_A para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Lista_Asignado_A()
        {
            var asignado_a_tabla = _context.ApplicationUser.Where(a => a.Area == 1).ToList();
            List<SelectListItem> lista_asignado_a = new List<SelectListItem>();
            RegisterViewModel rvm = new RegisterViewModel();
            foreach (var item in asignado_a_tabla)
            {
                lista_asignado_a.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = string.Format("{0} - {1} / {2}", item.UserName, item.FullName, item.Area)
                    });

            }

            return lista_asignado_a;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Plantas()
        {
            var plantas = _context.Planta.ToList();
            List<SelectListItem> lista_plantas = new List<SelectListItem>();
            RegisterViewModel rvm = new RegisterViewModel();
            foreach (var item in plantas)
            {
                lista_plantas.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre)
                    });

            }

            return lista_plantas;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Equipos_principales()
        {
            var equipoPrincipals = _context.EquipoPrincipal.ToList();
            List<SelectListItem> lista = new List<SelectListItem>();
            RegisterViewModel rvm = new RegisterViewModel();
            foreach (var item in equipoPrincipals)
            {
                lista.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre)
                    });

            }

            return lista;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Equipos_Secundarios()
        {
            var equipoSecundarios = _context.EquipoSecundario.ToList();
            List<SelectListItem> lista = new List<SelectListItem>();
            RegisterViewModel rvm = new RegisterViewModel();
            foreach (var item in equipoSecundarios)
            {
                lista.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre)
                    });

            }

            return lista;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Componentes()
        {
            var componentes = _context.Componentes.ToList();
            List<SelectListItem> lista = new List<SelectListItem>();
            RegisterViewModel rvm = new RegisterViewModel();
            foreach (var item in componentes)
            {
                lista.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre)
                    });

            }

            return lista;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Estados_Servicio()
        {
            var estado_servicios = _context.EstadoServicio.ToList();
            List<SelectListItem> lista = new List<SelectListItem>();
            RegisterViewModel rvm = new RegisterViewModel();
            foreach (var item in estado_servicios)
            {
                lista.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre)
                    });

            }

            return lista;
        }



        #endregion
    }
}
