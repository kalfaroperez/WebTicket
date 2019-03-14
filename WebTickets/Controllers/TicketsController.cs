using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Model.Auth;
using Model.DB_Model;
using Persistence.DatabaseContext;
using WebTickets.Helpers;
using WebTickets.ViewModels;
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
        public async Task<IActionResult> Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? page,
            int countOfPageIndexesToDisplay)
        {

            int pageSize = 10;
            ViewData["Numero_Ticket"] = String.IsNullOrEmpty(sortOrder) ? "Numero_Ticket" : "";
            ViewData["Prioridad"] = String.IsNullOrEmpty(sortOrder) ? "Prioridad" : "";
            ViewData["Fecha"] = String.IsNullOrEmpty(sortOrder) ? "Fecha" : "";
            ViewData["Username"] = String.IsNullOrEmpty(sortOrder) ? "Username" : "";
            ViewData["Operador_Nombre_Completo"] = String.IsNullOrEmpty(sortOrder) ? "Operador_Nombre_Completo" : "";
            ViewData["Asignado_A"] = String.IsNullOrEmpty(sortOrder) ? "Asignado_A" : "";
            ViewData["EstadoServicio"] = String.IsNullOrEmpty(sortOrder) ? "EstadoServicio" : "";
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var result = new List<TicketListViewModel>();
            try
            {
                //Resultado Consulta
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

                if (!String.IsNullOrEmpty(searchString))
                {
                    result = result.Where(s => s.Numero_Ticket.Contains(searchString) ||
                                          s.Username.Contains(searchString) ||
                                          s.Operador_Nombre_Completo.Contains(searchString) ||
                                          s.Operador_Nombre_Completo.Contains(searchString) ||
                                          s.Asignado_A.Contains(searchString) ||
                                          s.Fecha.ToShortDateString().Contains(searchString) ||
                                          s.EstadoServicio.Contains(searchString)).ToList();
                }

                if (string.IsNullOrEmpty(sortOrder))
                {
                    sortOrder = "Numero_Ticket";
                }

                //Sorting
                switch (sortOrder)
                {
                    case "Numero_Ticket":
                        result = result.OrderBy(r => r.Numero_Ticket).ToList();
                        break;
                    case "Prioridad":
                        result = result.OrderBy(r => r.Prioridad).ToList();
                        break;
                    case "Fecha":
                        result = result.OrderBy(r => r.Fecha).ToList();
                        break;
                    case "Username":
                        result = result.OrderBy(r => r.Username).ToList();
                        break;
                    case "Operador_Nombre_Completo":
                        result = result.OrderBy(r => r.Operador_Nombre_Completo).ToList();
                        break;
                    case "Asignado_A":
                        result = result.OrderBy(r => r.Asignado_A).ToList();
                        break;
                    case "EstadoServicio":
                        result = result.OrderBy(r => r.EstadoServicio).ToList();
                        break;
                    default:
                        result = result.OrderBy(r => r.Numero_Ticket).ToList();
                        break;
                }



            }
            catch (Exception e)
            {

                _logger.LogError(e.Message);
            }
            //int pageSize = 3;
            //int pageNumber = (page ?? 1);
            //return View(await PaginatedList<TicketListViewModel>.CreateAsync(result, page ?? 1, pageSize));
            return View(PaginatedList<TicketListViewModel>.Create(
                result,
                page ?? 1,
                pageSize,
                5));
        }

        // GET: Tickets
        [HttpGet]
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
                    Username = (_context.ApplicationUser.Find(x.Usuario_Id) != null) ? _context.ApplicationUser.Find(x.Usuario_Id).UserName : "-",
                    Operador_Nombre_Completo = (_context.ApplicationUser.Find(x.Usuario_Id) != null) ? _context.ApplicationUser.Find(x.Usuario_Id).FullName : "-",
                    Prioridad = (_context.Prioridad.Find(x.Prioridad) != null) ? _context.Prioridad.Find(x.Prioridad).Nombre_Prioridad : "-",
                    Asignado_A = (_context.ApplicationUser.Find(x.Asignado_A) != null) ? _context.ApplicationUser.Find(x.Asignado_A).UserName : "-",
                    Fecha = x.Fecha,
                    Fecha_Entrega = x.Fecha_Entrega,
                    EstadoServicio = (_context.EstadoServicio.Find(x.Estado) != null) ? _context.EstadoServicio.Find(x.Estado).Nombre : "-"
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
                string rol = await GetUserRoleName(tvm.Usuario_Id);

                if (User.IsInRole("Operador"))
                {
                    Ticket ticket = Fill_TicketModel(tvm, rol);
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
                else if (User.IsInRole("Administrador"))
                {
                    Ticket ticket = Fill_TicketModel(tvm, rol);
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

            }
            CargarFormulario_Tickets(tvm);
            return View(tvm);
        }

        //Devuel el Rol del Usuario a partir del ID del usaurio
        private async Task<string> GetUserRoleName(string UsuarioId)
        {
            var user = await _userManager.FindByIdAsync(UsuarioId);
            var roles = await _userManager.GetRolesAsync(user);
            string rol = roles[0].ToString();
            return rol;
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
                        string rol = await GetUserRoleName(tvm.Usuario_Id);
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


                        tvm.Error = "No se ha podido guardar el registro. Ha ocurrido un error "
                                            + ex.Message + ex.InnerException;
                        var ticket = _context.Ticket.AsNoTracking().FirstOrDefault(t => t.Id == tvm.Id);
                        TicketViewModel tvm2 = CargarFormulario_Tickets(ticket);
                        return View(tvm2);
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
                    //ValorAnterior = _context.ApplicationUser.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Operador_Id).FullName,
                    //ValorActual = _context.ApplicationUser.AsNoTracking().SingleOrDefault(t => t.Id == tvm.Operador_Id).FullName,
                    ValorAnterior =
                        (ticket.Operador_Id == "0") ? "0" :
                    _context.ApplicationUser.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Operador_Id).FullName,
                    ValorActual =
                    (tvm.Operador_Id.ToString() == "0") ? "0" :
                    _context.ApplicationUser.AsNoTracking().First(t => t.Id == tvm.Operador_Id).FullName,
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
                    //ValorAnterior = _context.Planta.AsNoTracking().SingleOrDefault(a => a.Id == ticket.Area_Id).Nombre,
                    //ValorActual = _context.Planta.AsNoTracking().SingleOrDefault(a => a.Id == tvm.Area_Id).Nombre,
                    ValorAnterior =
                        (ticket.Area_Id == 0) ? "0" :
                    _context.Area.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Area_Id).Nombre,
                    ValorActual =
                    (tvm.Area_Id.ToString() == "0") ? "0" :
                    _context.Area.AsNoTracking().First(t => t.Id == tvm.Area_Id).Nombre,
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
                    //ValorAnterior = _context.Prioridad.AsNoTracking().SingleOrDefault(p => p.Id == ticket.Prioridad).Nombre_Prioridad,
                    //ValorActual = _context.Prioridad.AsNoTracking().SingleOrDefault(p => p.Id == tvm.Prioridad).Nombre_Prioridad,
                    ValorAnterior =
                        (ticket.Prioridad == 0) ? "0" :
                    _context.Prioridad.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Prioridad).Nombre_Prioridad,
                    ValorActual =
                    (tvm.Prioridad.ToString() == "0") ? "0" :
                    _context.Prioridad.AsNoTracking().First(t => t.Id == tvm.Prioridad).Nombre_Prioridad,
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
                    //ValorAnterior = _context.Procesos.AsNoTracking().SingleOrDefault(p => p.Id == ticket.Proceso).Nombre_Proceso,
                    //ValorActual = _context.Procesos.AsNoTracking().SingleOrDefault(p => p.Id == tvm.Proceso).Nombre_Proceso,
                    ValorAnterior =
                        (ticket.Proceso == 0) ? "0" :
                    _context.Procesos.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Proceso).Nombre_Proceso,
                    ValorActual =
                    (tvm.Proceso.ToString() == "0") ? "0" :
                    _context.Procesos.AsNoTracking().First(t => t.Id == tvm.Proceso).Nombre_Proceso,
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
                    ValorAnterior =
                        (ticket.Asignado_A == "0") ? "0" :
                    _context.ApplicationUser.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Asignado_A).FullName,
                    ValorActual =
                    (tvm.Asignado_A == "0" || tvm.Asignado_A == null) ? "0" :
                    _context.ApplicationUser.AsNoTracking().First(t => t.Id == tvm.Asignado_A).FullName,
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
                    //ValorAnterior = _context.TipoTrabajo.AsNoTracking().SingleOrDefault(tt => tt.Id == ticket.Tipo_Trabajo).Nombre,
                    //ValorActual = _context.TipoTrabajo.AsNoTracking().SingleOrDefault(tt => tt.Id == tvm.Tipo_Trabajo).Nombre,
                    ValorAnterior =
                        (ticket.Tipo_Trabajo == 0) ? "0" :
                    _context.TipoTrabajo.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Tipo_Trabajo).Nombre,
                    ValorActual =
                    (tvm.Tipo_Trabajo == 0) ? "0" :
                    _context.TipoTrabajo.AsNoTracking().First(t => t.Id == tvm.Tipo_Trabajo).Nombre,
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
                    //ValorAnterior = _context.Planta.AsNoTracking().SingleOrDefault(p => p.Id == ticket.Id_Planta).Nombre,
                    //ValorActual = _context.Planta.AsNoTracking().SingleOrDefault(p => p.Id == tvm.Planta).Nombre,
                    ValorAnterior =
                        (ticket.Id_Planta == 0) ? "0" :
                    _context.Planta.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Id_Planta).Nombre,
                    ValorActual =
                    (tvm.Planta == 0) ? "0" :
                    _context.Planta.AsNoTracking().First(t => t.Id == tvm.Planta).Nombre,
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
                    //ValorAnterior = _context.EquipoPrincipal.AsNoTracking().SingleOrDefault(ep => ep.Id == ticket.Id_EquipoPrinc).Nombre,
                    //ValorActual = _context.EquipoPrincipal.AsNoTracking().SingleOrDefault(ep => ep.Id == tvm.EquipoPrincipal).Nombre,
                    ValorAnterior =
                        (ticket.Id_EquipoPrinc == 0) ? "0" :
                    _context.EquipoPrincipal.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Id_EquipoPrinc).Nombre,
                    ValorActual =
                    (tvm.EquipoPrincipal == 0) ? "0" :
                    _context.EquipoPrincipal.AsNoTracking().First(t => t.Id == tvm.EquipoPrincipal).Nombre,
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
                    //ValorAnterior = _context.EquipoSecundario.AsNoTracking().SingleOrDefault(es => es.Id == ticket.Id_EquipoSec).Nombre,
                    //ValorActual = _context.EquipoSecundario.AsNoTracking().SingleOrDefault(es => es.Id == tvm.EquipoSecundario).Nombre,
                    ValorAnterior =
                        (ticket.Id_EquipoSec == 0) ? "0" :
                    _context.EquipoSecundario.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Id_EquipoSec).Nombre,
                    ValorActual =
                    (tvm.EquipoSecundario == 0) ? "0" :
                    _context.EquipoSecundario.AsNoTracking().First(t => t.Id == tvm.EquipoPrincipal).Nombre,
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
                    //ValorAnterior = _context.Componentes.AsNoTracking().SingleOrDefault(c => c.Id == ticket.Id_Componente).Nombre,
                    //ValorActual = _context.Componentes.AsNoTracking().SingleOrDefault(c => c.Id == tvm.Componente).Nombre,
                    ValorAnterior =
                        (ticket.Id_Componente == 0) ? "0" :
                    _context.Componentes.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Id_Componente).Nombre,
                    ValorActual =
                    (tvm.Componente == 0) ? "0" :
                    _context.Componentes.AsNoTracking().First(t => t.Id == tvm.Componente).Nombre,
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
                    //ValorAnterior = _context.EstadoServicio.AsNoTracking().FirstOrDefault(es => es.Id == ticket.Estado).Nombre,
                    //ValorActual = _context.EstadoServicio.AsNoTracking().FirstOrDefault(es => es.Id == tvm.Estado).Nombre,
                    ValorAnterior =
                        (ticket.Estado == 0) ? "0" :
                    _context.EstadoServicio.AsNoTracking().SingleOrDefault(t => t.Id == ticket.Estado).Nombre,
                    ValorActual =
                    (tvm.Componente == 0) ? "0" :
                    _context.EstadoServicio.AsNoTracking().First(t => t.Id == tvm.Estado).Nombre,
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
        public IActionResult GetUsuario([FromBody]string id)
        {

            UsuarioViewModel uvm = new UsuarioViewModel();
            var item = _context.ApplicationUser.First(u => u.Id == id);
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

        [HttpPost]
        public IActionResult BuscarTicket([FromBody]string txtBuscar)
        {

            var tickets = from a in _context.Ticket
                          where a.Numero_Ticket == txtBuscar
                          select a;

            /*List<TicketListViewModel> lista = new List<TicketListViewModel>();
            foreach (var item in tickets)
            {

            }*/

            return Json(tickets);
        }

        #region Helpers

        private Ticket Fill_TicketModel(TicketViewModel tvm, string rol_usuario_sesion)
        {

            Ticket ticket = new Ticket();
            if (User.IsInRole("Administrador"))
            {
                ticket = new Ticket
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
            }
            else if (User.IsInRole("Operador"))
            {
                ticket = new Ticket
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
                    Asignado_A = "0",
                    Prioridad = 0,
                    Incidente = tvm.Incidente,
                    Comentarios = tvm.Comentarios,
                    Proceso = 0,
                    Tipo_Trabajo = 0,
                    Id_Planta = 0,
                    Id_EquipoPrinc = 0,
                    Id_EquipoSec = 0,
                    Id_Componente = 0,
                    Estado = 0,
                    Calificacion = tvm.Calificacion == "0" ? "0" : tvm.Calificacion,
                    Fecha_Entrega = DateTime.Now,
                    Fecha_Ultimo_Estado = DateTime.Now,
                    Insert_Datetime = DateTime.Now,
                    Update_Datetime = DateTime.Now
                };
            }
            if (tvm.Id.ToString() != null)
            {
                ticket.Id = tvm.Id;
            }
            return ticket;
        }

        private Ticket Fill_TicketModel(TicketViewModel tvm)
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
                Calificacion = tvm.Calificacion == "0" ? "0" : tvm.Calificacion,
                Fecha_Entrega = tvm.Fecha_Entrega,
                Fecha_Ultimo_Estado = DateTime.Now,
                Insert_Datetime = DateTime.Now,
                Update_Datetime = DateTime.Now
            };

            #region Comentado
            /*
            if (User.IsInRole("Administrador"))
            {
                ticket = new Ticket
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
                    Calificacion = tvm.Calificacion == "0" ? "0" : tvm.Calificacion,
                    Fecha_Entrega = tvm.Fecha_Entrega,
                    Fecha_Ultimo_Estado = DateTime.Now,
                    Insert_Datetime = DateTime.Now,
                    Update_Datetime = DateTime.Now
                };
            }
            else if (User.IsInRole("Operador"))
            {
                ticket = new Ticket
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
                    Asignado_A = "0",
                    Prioridad = 0,
                    Incidente = tvm.Incidente,
                    Comentarios = tvm.Comentarios,
                    Proceso = 0,
                    Tipo_Trabajo = 0,
                    Id_Planta = 0,
                    Id_EquipoPrinc = 0,
                    Id_EquipoSec = 0,
                    Id_Componente = 0,
                    Estado = 0,
                    Calificacion = tvm.Calificacion == "0" ? "0" : tvm.Calificacion,
                    Fecha_Entrega = DateTime.Now,
                    Fecha_Ultimo_Estado = DateTime.Now,
                    Insert_Datetime = DateTime.Now,
                    Update_Datetime = DateTime.Now
                };
            }*/
            #endregion

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
            tvm.Lista_Prioridades = GetPrioridades(tvm.Prioridad);

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
            tvm.Lista_Componentes = Get_Componentes(tvm.Componente);

            //Selector EstadoServicio
            tvm.Lista_Estados = Get_Estados_Servicio();

            //Selector EstadoServicio
            tvm.Lista_Calificaion = Get_Calificacion_Servicios_List();
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
            tvm.Lista_Prioridades = GetPrioridades(ticket.Prioridad);
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
            tvm.Lista_Componentes = Get_Componentes(ticket.Id_Componente);
            tvm.Componente = ticket.Id_Componente;

            //Selector Estados
            tvm.Lista_Estados = Get_Estados_Servicio();
            tvm.Estado = ticket.Estado;

            //Selector CalificacionServicio
            tvm.Lista_Calificaion = Get_Calificacion_Servicios_List();
            tvm.Calificacion = ticket.Calificacion;

            tvm.Fecha_Entrega = ticket.Fecha_Entrega;
            tvm.Fecha_Ultimo_Estado = ticket.Fecha_Ultimo_Estado;



            return tvm;
        }

        [HttpPost]
        public IActionResult GetUsuarios()
        {
            var usuarios = _context.ApplicationUser.Join(_context.Area,
                u => u.Area,
                a => a.Id,
                (u, a) => new { u.Id, u.FullName, area = a.Nombre }).ToList();
            return Json(usuarios);
        }

        [HttpPost]
        public IActionResult GetSeguimientoTicket_NG([FromBody]SigoTicketViewModel sigo)
        {

            List<SeguimientoViewModel> lista_seg = new List<SeguimientoViewModel>();
            var id_ticket = sigo.Id;

            var cambios = from st in _context.SigoTicket
                          join us in _context.ApplicationUser on st.UsuarioId equals us.Id
                          where st.SeqTicketId == Convert.ToInt32(id_ticket)
                          group new { st.Fecha, us.FullName, st.CambioNumero } by st.CambioNumero into stGr
                          select new
                          {
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
        private List<SelectListItem> GetPrioridades(int Id_Prioridad)
        {
            var prioridades = _context.Prioridad.ToList();
            List<SelectListItem> lista_prioridades = new List<SelectListItem>();
            foreach (var item in prioridades)
            {
                lista_prioridades.Add(
                    new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre_Prioridad),
                        Disabled = (item.Id == Id_Prioridad) ? false : true
                    });

            }

            return lista_prioridades;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Prioridad"
        /// </summary>
        /// <returns>Devuelve la Lista de Prioridades para ser cargadas en un selector</returns>
        [HttpGet]
        public IActionResult GetPrioridades_Ajax(string term)
        {
            var prioridades = new List<Prioridad>();
            if (string.IsNullOrEmpty(term)) { prioridades = _context.Prioridad.ToList(); }
            else
            {
                prioridades = _context.Prioridad.Where(t => t.Nombre_Prioridad.ToUpper().Contains(term.ToUpper())).ToList();
            }
            List<ComboBoxSelect2> lista_prioridades = new List<ComboBoxSelect2>();
            foreach (var item in prioridades)
            {
                lista_prioridades.Add(
                    new ComboBoxSelect2
                    {
                        Id = item.Id.ToString(),
                        Text = item.Nombre_Prioridad
                    });

            }

            return Json(lista_prioridades);
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

        [HttpGet]
        public IActionResult GetProcesos_Ajax(string term)
        {
            var procesos = new List<Procesos>();
            if (string.IsNullOrEmpty(term))
            {
                procesos = _context.Procesos.ToList();
            }
            else
            {
                procesos = _context.Procesos.Where(t => t.Nombre_Proceso.ToUpper().Contains(term.ToUpper())).ToList();
            }
            List<ComboBoxSelect2> lista_procesos = new List<ComboBoxSelect2>();
            foreach (var item in procesos)
            {
                lista_procesos.Add(
                    new ComboBoxSelect2
                    {
                        Id = item.Id.ToString(),
                        Text = item.Nombre_Proceso
                    });

            }

            return Json(lista_procesos);
        }
        /// <summary>
        /// Obtiene los registros de la entidad "Tipo_Trabajo"
        /// </summary>
        /// <returns>Devuelve la Lista de Tipos de Trabajo para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Tipo_Trabajos()
        {
            var tipoTrabajos = _context.TipoTrabajo.ToList();
            List<SelectListItem> lista_tipo_trabajos = new List<SelectListItem>();
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

        [HttpGet]
        public IActionResult GetTipoTrabajoAjax(string term)
        {
            var tipo_trabajo = new List<TipoTrabajo>();
            if (string.IsNullOrEmpty(term))
            {
                tipo_trabajo = _context.TipoTrabajo.ToList();
            }
            else
            {
                tipo_trabajo = _context.TipoTrabajo.Where(t => t.Nombre.ToUpper().Contains(term.ToUpper())).ToList();
            }
            List<ComboBoxSelect2> lista_trabajo = new List<ComboBoxSelect2>();
            foreach (var item in tipo_trabajo)
            {
                lista_trabajo.Add(
                    new ComboBoxSelect2
                    {
                        Id = item.Id.ToString(),
                        Text = item.Nombre
                    });

            }

            return Json(lista_trabajo);
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Asignado_A"
        /// </summary>
        /// <returns>Devuelve la Lista de Asignado_A para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Lista_Asignado_A()
        {
            var asignado_a_tabla = _context.ApplicationUser.Where(a => a.Area == 1).ToList();
            List<SelectListItem> lista_asignado_a = new List<SelectListItem>();
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
        /// Obtiene los registros de la entidad "Asignado_A"
        /// </summary>
        /// <returns>Devuelve la Lista de Asignado_A para ser cargadas en un selector</returns>
        ///
        [HttpGet]
        public IActionResult GetAsignadoAjax(string term)
        {
            List<ApplicationUser> asignados = new List<ApplicationUser>();
            var lista_asignado_a = new List<ComboBoxSelect2>();
            if (string.IsNullOrEmpty(term))
            {
                asignados = _context.ApplicationUser.Where(a => a.Area == 1).ToList();
            }
            else
            {
                asignados = _context.ApplicationUser.
                    Where(t => t.FullName.ToUpper().Contains(term.ToUpper()) && t.Area == 1).ToList();
            }
            foreach (var item in asignados)
            {
                lista_asignado_a.Add(
                    new ComboBoxSelect2
                    {
                        Id = item.Id,
                        Text = string.Format("{0} - {1} / {2}", item.UserName, item.FullName, item.Area)
                    });

            }


            var procesos = new List<Procesos>();
            if (string.IsNullOrEmpty(term)) { procesos = _context.Procesos.ToList(); }
            else
            {
                procesos = _context.Procesos.Where(t => t.Nombre_Proceso.ToUpper().Contains(term.ToUpper())).ToList();
            }
            List<ComboBoxSelect2> lista_procesos = new List<ComboBoxSelect2>();
            foreach (var item in procesos)
            {
                lista_procesos.Add(
                    new ComboBoxSelect2
                    {
                        Id = item.Id.ToString(),
                        Text = item.Nombre_Proceso
                    });

            }

            return Json(lista_asignado_a);
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        /// 
        [HttpPost]
        public IActionResult Get_Plantas_Ajax(string term)
        {
            //var plantas = _context.Planta.Where(t => t.Nombre.Contains(term)).ToList();
            var plantas = new List<ComboBoxSelect2>();
            if (String.IsNullOrEmpty(term))
            {
                plantas = (from p in _context.Planta
                           select new ComboBoxSelect2
                           {
                               Id = p.Id.ToString(),
                               Text = p.Nombre
                           }).ToList();
            }
            else
            {
                plantas = (from p in _context.Planta
                           where p.Nombre.ToUpper().Contains(term.ToUpper())
                           select new ComboBoxSelect2
                           {
                               Id = p.Id.ToString(),
                               Text = p.Nombre
                           }).ToList();
            }

            return Json(plantas);
        }


        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Plantas()
        {
            var plantas = _context.Planta.ToList();
            List<SelectListItem> lista_plantas = new List<SelectListItem>();
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
        /// 
        [HttpPost]
        public IActionResult Get_Equipos_principales_Ajax(string term, string id_planta)
        {
            //var plantas = _context.Planta.Where(t => t.Nombre.Contains(term)).ToList();
            var equipos_principales = new List<ComboBoxSelect2>();
            if (String.IsNullOrEmpty(term))
            {
                var agrupado =
                     (from ep in _context.RegistroEquipo
                      where ep.IdPlanta.ToString() == id_planta
                      group ep by new { Id = ep.IdEquipoPrinc.ToString(), Text = ep.NombreEquipoPrinc } into newGroup
                      select newGroup).ToList();

                foreach (var item in agrupado)
                {
                    ComboBoxSelect2 cs = new ComboBoxSelect2();
                    cs.Id = item.Key.Id;
                    cs.Text = item.Key.Text;
                    equipos_principales.Add(cs);
                }
            }
            else
            {
                var agrupado =
                     (from ep in _context.RegistroEquipo
                      where ep.IdPlanta.ToString() == id_planta &&
                      ep.NombreEquipoPrinc.ToUpper().Contains(term.ToUpper())
                      group ep by new { Id = ep.IdEquipoPrinc.ToString(), Text = ep.NombreEquipoPrinc } into newGroup
                      //orderby newGroup.Key
                      select newGroup).ToList();

                foreach (var item in agrupado)
                {
                    ComboBoxSelect2 cs = new ComboBoxSelect2();
                    cs.Id = item.Key.Id.ToString();
                    cs.Text = item.Key.Text;
                    equipos_principales.Add(cs);
                }

            }

            return Json(equipos_principales);
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
        /// 
        [HttpPost]
        public IActionResult Get_Equipos_Secundarios_Ajax(string term, string id_planta, string id_equipo_princ)
        {
            //var plantas = _context.Planta.Where(t => t.Nombre.Contains(term)).ToList();
            var equipos_secundarios = new List<ComboBoxSelect2>();
            if (String.IsNullOrEmpty(term))
            {
                var agrupado =
                     (from ep in _context.RegistroEquipo
                      where ep.IdPlanta.ToString() == id_planta && ep.IdEquipoPrinc.ToString() == id_equipo_princ
                      group ep by new { Id = ep.IdEquipoSec.ToString(), Text = ep.NombreEquipoSec } into newGroup
                      select newGroup).ToList();

                foreach (var item in agrupado)
                {
                    ComboBoxSelect2 cs = new ComboBoxSelect2();
                    cs.Id = item.Key.Id;
                    cs.Text = item.Key.Text;
                    equipos_secundarios.Add(cs);
                }
            }
            else
            {
                var agrupado =
                     (from ep in _context.RegistroEquipo
                      where ep.IdPlanta.ToString() == id_planta
                      && ep.IdEquipoPrinc.ToString() == id_equipo_princ
                      && ep.NombreEquipoSec.ToUpper().Contains(term.ToUpper())
                      group ep by new { Id = ep.IdEquipoSec.ToString(), Text = ep.NombreEquipoSec } into newGroup
                      //orderby newGroup.Key
                      select newGroup).ToList();

                foreach (var item in agrupado)
                {
                    ComboBoxSelect2 cs = new ComboBoxSelect2();
                    cs.Id = item.Key.Id.ToString();
                    cs.Text = item.Key.Text;
                    equipos_secundarios.Add(cs);
                }

            }

            return Json(equipos_secundarios);
        }
        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Componentes(int Id_Componente)
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
                        Text = string.Format("{0}", item.Nombre),
                        Disabled = (item.Id == Id_Componente) ? false : true
                    });

            }

            return lista;
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        [HttpPost]
        public IActionResult Get_Componentes_Ajax(string term, string id_planta, string id_equipo_princ, string id_equipo_sec)
        {
            var componentes = new List<ComboBoxSelect2>();
            if (String.IsNullOrEmpty(term))
            {
                var agrupado =
                     (from ep in _context.RegistroEquipo
                      where ep.IdPlanta.ToString() == id_planta
                      && ep.IdEquipoPrinc.ToString() == id_equipo_princ
                      && ep.IdEquipoSec.ToString() == id_equipo_sec
                      group ep by new { Id = ep.IdComponente.ToString(), Text = ep.NombreComponente } into newGroup
                      select newGroup).ToList();

                foreach (var item in agrupado)
                {
                    ComboBoxSelect2 cs = new ComboBoxSelect2();
                    cs.Id = item.Key.Id;
                    cs.Text = item.Key.Text;
                    componentes.Add(cs);
                }
            }
            else
            {
                var agrupado =
                     (from ep in _context.RegistroEquipo
                      where ep.IdPlanta.ToString() == id_planta
                      && ep.IdEquipoPrinc.ToString() == id_equipo_princ
                      && ep.IdEquipoSec.ToString() == id_equipo_sec
                      && ep.NombreComponente.ToUpper().Contains(term.ToUpper())
                      group ep by new { Id = ep.IdEquipoSec.ToString(), Text = ep.NombreEquipoSec } into newGroup
                      //orderby newGroup.Key
                      select newGroup).ToList();

                foreach (var item in agrupado)
                {
                    ComboBoxSelect2 cs = new ComboBoxSelect2();
                    cs.Id = item.Key.Id.ToString();
                    cs.Text = item.Key.Text;
                    componentes.Add(cs);
                }

            }

            return Json(componentes);
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        private List<SelectListItem> Get_Estados_Servicio()
        {
            var estado_servicios = _context.EstadoServicio.ToList();
            List<SelectListItem> lista = new List<SelectListItem>();
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

        private List<SelectListItem> Get_Calificacion_Servicios_List()
        {
            var calificacionServicios = _context.CalificacionServicio.ToList();
            List<SelectListItem> lista = new List<SelectListItem>();
            foreach (var item in calificacionServicios)
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
        [HttpGet]
        public IActionResult GetEstadosServicioAjax(string term)
        {
            var estado_servicios = new List<EstadoServicio>();
            if (string.IsNullOrEmpty(term))
            {
                estado_servicios = _context.EstadoServicio.ToList();
            }
            else
            {
                estado_servicios = _context.EstadoServicio.Where(t => t.Nombre.ToUpper().Contains(term.ToUpper())).ToList();
            }
            List<ComboBoxSelect2> lista = new List<ComboBoxSelect2>();
            foreach (var item in estado_servicios)
            {
                lista.Add(
                    new ComboBoxSelect2
                    {
                        Id = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre)
                    });

            }

            return Json(lista);
        }

        /// <summary>
        /// Obtiene los registros de la entidad "Planta"
        /// </summary>
        /// <returns>Devuelve la Lista de Planta para ser cargadas en un selector</returns>
        [HttpGet]
        public IActionResult GetCalificacionServicioAjax(string term)
        {
            var calificaion_servicios = new List<CalificacionServicio>();
            if (string.IsNullOrEmpty(term))
            {
                calificaion_servicios = _context.CalificacionServicio.ToList();
            }
            else
            {
                calificaion_servicios = _context.CalificacionServicio.Where(t => t.Nombre.ToUpper().Contains(term.ToUpper())).ToList();
            }
            List<ComboBoxSelect2> lista = new List<ComboBoxSelect2>();
            foreach (var item in calificaion_servicios)
            {
                lista.Add(
                    new ComboBoxSelect2
                    {
                        Id = item.Id.ToString(),
                        Text = string.Format("{0}", item.Nombre)
                    });

            }

            return Json(lista);
        }


        #endregion
    }

    public class ComboBoxSelect2
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }
}
