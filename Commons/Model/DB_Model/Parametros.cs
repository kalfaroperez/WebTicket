using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class Parametros
    {
        [Key]
        public int ParametrosId { get; set; }
        public ushort ValidezPsw { get; set; }
        public ushort DiasPsw { get; set; }
        public ushort MaxLinesScreen { get; set; }
        public uint MaxLinesExport { get; set; }
        public ushort MaxDifMin { get; set; }
        public uint MaxAttach { get; set; }
        public int AssignTicket { get; set; }
        public string FromUserRequest { get; set; }
        public string SubcarpetaAdjuntoTicket { get; set; }
        public string SubcarpetaAdjuntoFichaTec { get; set; }
        public string FromUserPsw { get; set; }
        public string ContactDefault { get; set; }
        public string ProcessDefault { get; set; }
        public string StateDefault { get; set; }
        public string StateAlert { get; set; }
        public string MainScreenState { get; set; }
        public string DateFormat { get; set; }
        public string Pen { get; set; }
        public string Pas { get; set; }
        public string Can { get; set; }
        public string InsertOper { get; set; }
        public DateTime InsertDatetime { get; set; }
        public string UpdateOper { get; set; }
        public DateTime UpdateDatetime { get; set; }
    }
}
