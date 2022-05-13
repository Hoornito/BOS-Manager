using System;

namespace Domain.Entities
{
    public class ReporteEntity
    {
        public int CodigoReporte { get; set; }
        public DateTime Fecha_desde { get; set; }
        public DateTime Fecha_hasta { get; set; }
    }
}
