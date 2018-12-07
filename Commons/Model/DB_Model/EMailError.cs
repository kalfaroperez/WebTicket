using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class EMailError
    {
        [Key]
        public long IdEmailError { get; set; }
        public string FromName { get; set; }
        public string FromEMail { get; set; }
        public string ToName { get; set; }
        public string ToEMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime FechaInsercion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
