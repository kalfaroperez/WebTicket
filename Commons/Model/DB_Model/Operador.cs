using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class Operador
    {
        [Key]
        public int IdOperador { get; set; }
        public string OperadorId { get; set; }
        public string ApeYNom { get; set; }
        public string SectorId { get; set; }
        public string EMail { get; set; }
        public string Contrasenia { get; set; }
        public int Privado { get; set; }
        public sbyte Nivel { get; set; }
        public DateTime ExpiraClave { get; set; }
        public int AvisarAsignado { get; set; }
        public int AvisarSolicitud { get; set; }
        public string InsertOper { get; set; }
        public DateTime InsertDatetime { get; set; }
        public string UpdateOper { get; set; }
        public DateTime UpdateDatetime { get; set; }
    }
}
