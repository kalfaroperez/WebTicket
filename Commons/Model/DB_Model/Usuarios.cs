using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class Usuarios
    {
        [Key]
        public long IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string EMail { get; set; }
        public string Ubicacion { get; set; }
        public string Telefono { get; set; }
        public int AreaId { get; set; }
        public int Activo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int CambioClave { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
