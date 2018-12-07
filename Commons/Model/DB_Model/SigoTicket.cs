using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class SigoTicket
    {
        [Key]
        public ulong SeqSigoTicketId { get; set; }
        public ulong SeqTicketId { get; set; }
        public DateTime Fecha { get; set; }
        public string OperadorId { get; set; }
        public string UsuarioId { get; set; }
        public string CampoCambiado { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorActual { get; set; }
        public string Comentario { get; set; }
        public int Visible { get; set; }
        public byte[] Adjunto { get; set; }
        public string TipoAdjunto { get; set; }
        public string NombreAdjunto { get; set; }
        public string InsertOper { get; set; }
        public string InsertUser { get; set; }
        public DateTime InsertDatetime { get; set; }
    }
}
