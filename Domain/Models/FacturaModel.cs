using System;

namespace Domain.Models
{
    public class FacturaModel
    {
        public int Id_Factura { get; set; }
        public decimal IVA { get; set; }
        public string BaseImponible { get; set; }
        public int Id_Pedido { get; set; }
        public string IVADiscriminado { get; set; }
        public DateTime FechaYHora { get; set; }

        public virtual PedidoModel Pedido { get; set; }
    }
}
