using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class HistorialPassword
    {
        [Key]
        public int Id_Historial_Password { get; set; }
        public int Id_Usuario { get; set; }
        public string Password { get; set; }
        public DateTime InsertDatetime { get; set; }
    }
}
