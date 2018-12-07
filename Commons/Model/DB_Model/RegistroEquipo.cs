using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class RegistroEquipo
    {
        [Key]
        public int Id { get; set; }
        public int IdPlanta { get; set; }
        public string NombrePlanta { get; set; }
        public int IdEquipoPrinc { get; set; }
        public string NombreEquipoPrinc { get; set; }
        public int? IdEquipoSec { get; set; }
        public string NombreEquipoSec { get; set; }
        public int? IdComponente { get; set; }
        public string NombreComponente { get; set; }
    }
}
