using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model.Auth;
using Model.DB_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTickets.ViewModels
{
    public class EquiposCommonListViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nombre no puede ser vacio")]
        [Display(Name = "Nombre")]
        [StringLength(60, ErrorMessage = "")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }

    public class FileUploadView
    {
        [Required]
        [Display(Name = "Nombre")]
        [StringLength(80, MinimumLength = 3)]
        public string Title { get; set; }

        //[Required]
        [Display(Name = "Public Schedule")]
        public IFormFile UploadPublicSchedule { get; set; }

        //[Required]
        [Display(Name = "Private Schedule")]
        public IFormFile UploadPrivateSchedule { get; set; }
    }

    public class EquiposPrincipalViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [StringLength(50, ErrorMessage = "El campo Nombre solo puede tener 50 caracteres")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public List<IFormFile> FileUpload { get; set; }
        public List<FileDetails> Files { get; set; }
            = new List<FileDetails>();
    }

    public class FileDetails
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime Fecha_modificacion { get; set; }
    }

    public class PlantaViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [StringLength(50, ErrorMessage = "El campo Nombre solo puede tener 50 caracteres")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        //public List<IFormFile> FileUpload { get; set; }
    }

    public class TicketViewModel
    {
        public ulong Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Ticket #")]
        public string Numero_Ticket { get; set; }

        private DateTime _fecha;

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime Fecha { get => DateTime.Now; set => _fecha = value; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El campo '{0}' es requerido")]
        public string Operador_UserName { get; set; }

        [Display(Name = "Nombre Completo")]
        public string Operador_Nombre_completo { get; set; }
        public string Operador_Id { get; set; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El campo '{0}' es requerido")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Usuario_Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [Display(Name = "Nombre Completo")]
        [StringLength(250, ErrorMessage = "El campo Nombre solo puede tener 250 caracteres")]
        public string Nombre_completo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Area { get; set; }
        public int Area_Id { get; set; }

        public string Ubicacion { get; set; }

        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Correo Electronico")]
        [EmailAddress]
        [StringLength(250, ErrorMessage = "El campo Nombre solo puede tener 250 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Incidente { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Comentarios { get; set; }

        [Display(Name = "Adjuntos")]
        public List<IFormFile> FileUpload { get; set; }
        public List<FileDetails> Files { get; set; }
            = new List<FileDetails>();

        [Display(Name = "Asignado A")]
        public string Asignado_A { get; set; }
        public string Asignado_A_Text{ get; set; }
        public List<SelectListItem> Lista_Asignados_A { get; set; }

        public string Asignado_A_Sector { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Prioridad { get; set; }
        public string Prioridad_Text { get; set; }
        public List<SelectListItem> Lista_Prioridades { get; set; }
         
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Proceso { get; set; }
        public string Proceso_Text { get; set; }
        public List<SelectListItem> Lista_Procesos { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Tipo Trabajo")]
        public int Tipo_Trabajo { get; set; }
        public string Tipo_Trabajo_Text { get; set; }
        public List<SelectListItem> Lista_Tipo_Trabajos { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Area Equipo")]
        public int Planta { get; set; }
        public string Planta_Text { get; set; }
        public List<SelectListItem> Lista_Plantas { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Equipo Principal")]
        public int EquipoPrincipal { get; set; }
        public string EquipoPrincipal_Text { get; set; }
        public List<SelectListItem> Lista_Equipos_princ { get; set; }

        [Display(Name = "Equipo Secundario")]
        public int EquipoSecundario { get; set; }
        public string EquipoSecundario_Text { get; set; }
        public List<SelectListItem> Lista_Equipos_sec { get; set; }

        [Display(Name = "Componente")]
        public int Componente { get; set; }
        public string Componente_Text { get; set; }
        public List<SelectListItem> Lista_Componentes { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Estado { get; set; }
        public string Estado_Text { get; set; }
        public List<SelectListItem> Lista_Estados { get; set; }

        public string Calificacion { get; set; }
        public List<SelectListItem> Lista_Calificaion { get; set; }

        public string Usuario { get; set; }
        public List<ApplicationUser> Lista_Usuarios { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime Fecha_Ultimo_Estado { get; set; }

        private DateTime _fecha_e;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime Fecha_Entrega { get; set; }

        [Display(Name = "Notas de Trabajo")]
        public string NotasTrabajo { get; set; }

        [Display(Name = "Notas Cierre Servicio")]
        public string NotaCierreServicio { get; set; }


        public string Error { get; set; }
        public string Exito { get; set; }
    }

    public class TicketListViewModel
    {
        public string Id { get; set; }
        public string Numero_Ticket { get; set; }

        [Display(Name = "Usuario")]
        public string Username { get; set; }

        [Display(Name = "Nombre Completo")]
        public string Operador_Nombre_Completo { get; set; }

        [Display(Name = "Asignado a")]
        public string Asignado_A { get; set; }

        [Display(Name = "Prioridad")]
        public string Prioridad { get; set; }


        [Display(Name = "Fecha Creacion")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Fecha Entrega")]
        public DateTime Fecha_Entrega { get; set; }

        public string EstadoServicio { get; set; }
    }

    public class SigoTicketViewModel
    {
        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        public string OperadorId { get; set; }
        public string UsuarioId { get; set; }
        public string NotasTrabajo { get; set; }
        public string CampoCambiado { get; set; }
        public int CambioNumero { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorActual { get; set; }
        public string Comentario { get; set; }
        public int Visible { get; set; }
        public string TipoAdjunto { get; set; }
        public string NombreAdjunto { get; set; }
        public string InsertOper { get; set; }
        public string InsertUser { get; set; }
        public DateTime InsertDatetime { get; set; }
    }

    public class SeguimientoViewModel
    {
        public string UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public int CambioNumero { get; set; }
        public List<SigoTicketViewModel> Cambios { get; set; } = new List<SigoTicketViewModel>();
    }

    public class UsuarioViewModel {
        //Solo lo usare para enviar parametros
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Nombre_completo { get; set; }
        public string Area { get; set; }
        public int Area_Id { get; set; }
        public string Email { get; set; }
        public string Ubicacion { get; set; }
        public string Telefono { get; set; }
    }
}
