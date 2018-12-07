using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class TipoTrabajo
    {   
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha_Insercion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
    }
}
