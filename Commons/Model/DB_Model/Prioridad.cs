using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class Prioridad
    {
        [Key]
        public int Id { get; set; }
        public string Nombre_Prioridad { get; set; }
        public DateTime? Fecha_Insercion { get; set; }
        public DateTime? Fecha_Modificacion { get; set; }
    }
}
