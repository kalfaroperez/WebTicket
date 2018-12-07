using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model.Auth;
using Model.DB_Model;
using Persistence.DatabaseContext;
using WebTickets.ViewModels;

namespace WebTickets.Controllers
{
    
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;

        public TicketsController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILoggerFactory loggerFactory,
            ApplicationDbContext context)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = loggerFactory.CreateLogger<TicketsController>();
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ticket.ToListAsync());
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
            return View(tvm);
        }
               

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TicketViewModel tvm)
        {
            if (ModelState.IsValid)
            {
                Ticket ticket = Fill_TicketModel(tvm);
                _context.Add(ticket);
                await _context.SaveChangesAsync();

                SigoTicket sigoTicket = new SigoTicket
                {
                    SeqTicketId = ticket.Id,
                    Fecha = DateTime.Now,
                    OperadorId = ticket.Operador_Id,
                    UsuarioId = ticket.Usuario_Id,
                    CampoCambiado = "Comentarios",
                    ValorActual = ticket.Comentarios
                };
                _context.SigoTicket.Add(sigoTicket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
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
            TicketViewModel tvm = new TicketViewModel();
            CargarFormulario_Tickets(tvm);
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ulong id, [Bind("Id,Numero_Ticket,Fecha,Privado,Operador_Id,Operador_Sector_Id,Usuario_Id,Nombre_completo,Area_Id,Piso,Telefono,EMail,Asignado_A,Asignado_A_Sector,Prioridad,Incidente,Proceso,Tipo_Trabajo,Id_Planta,Id_EquipoPrinc,Id_EquipoSec,Id_Componente,Estado,Calificacion,Fecha_Ultimo_Estado,Fecha_Entrega,Operador_Ultimo_Estado,Adjunto,Tipo_Adjunto,Ruta_Adjunto,Nombre_Adjunto,Insert_Oper,Insert_Datetime,Update_Oper,Update_Datetime")] Ticket ticket)
        {
            if (id != ticket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.Id))
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
            return View(ticket);
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

        private bool TicketExists(ulong id)
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
                return NotFound() ;
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
                Fecha_Ultimo_Estado = tvm.Fecha_Ultimo_Estado,
                Insert_Datetime = DateTime.Now,
                Update_Datetime = DateTime.Now
            };
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

            tvm.Lista_Usuarios = Get_Usuarios();
            return tvm;
        }

        private List<ApplicationUser> Get_Usuarios()
        {
            var usuarios = _context.ApplicationUser.ToList();
            return usuarios;
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
