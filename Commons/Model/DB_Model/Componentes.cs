﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class Componentes
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string Insert_Oper { get; set; }
        public DateTime Insert_Datetime { get; set; }
        public string Update_Oper { get; set; }
        public DateTime Update_Datetime { get; set; }
    }
}
