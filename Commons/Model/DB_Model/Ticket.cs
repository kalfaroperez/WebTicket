using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB_Model
{
    public partial class Ticket
    {
        [Key]
        public ulong Id { get; set; }
        public string Numero_Ticket { get; set; }
        public DateTime Fecha { get; set; }
        public int Privado { get; set; }
        public string Operador_Id { get; set; }
        public string Operador_Sector_Id { get; set; }
        public string Usuario_Id { get; set; }
        public string Nombre_completo { get; set; }
        public int Area_Id { get; set; }
        public string Ubicacion { get; set; }
        public string Telefono { get; set; }
        public string EMail { get; set; }
        public string Asignado_A { get; set; }
        public string Asignado_A_Sector { get; set; }
        public int Prioridad { get; set; }
        public string Incidente { get; set; }
        public string Comentarios { get; set; }
        public int Proceso { get; set; }
        public int Tipo_Trabajo { get; set; }
        public int Id_Planta { get; set; }
        public int Id_EquipoPrinc { get; set; }
        public int Id_EquipoSec { get; set; }
        public int Id_Componente { get; set; }
        public int Estado { get; set; }
        public string Calificacion { get; set; }
        public DateTime Fecha_Ultimo_Estado { get; set; }
        public DateTime? Fecha_Entrega { get; set; }
        public string Operador_Ultimo_Estado { get; set; }
        public byte[] Adjunto { get; set; }
        public string Tipo_Adjunto { get; set; }
        public string Ruta_Adjunto { get; set; }
        public string Nombre_Adjunto { get; set; }
        public string Insert_Oper { get; set; }
        public DateTime Insert_Datetime { get; set; }
        public string Update_Oper { get; set; }
        public DateTime Update_Datetime { get; set; }
    }
}
