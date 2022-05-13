using System;

namespace Domain.Entities
{
    public class HistoricoEntity
    {
        public string Descripción { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Historico { get; set; }
        public string Tipo { get; set; }
    }
}
