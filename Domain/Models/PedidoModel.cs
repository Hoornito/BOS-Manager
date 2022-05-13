using System.Collections.Generic;

namespace Domain.Models
{
    public class PedidoModel
    {
        public PedidoModel()
        {
            this.Factura = new HashSet<FacturaModel>();
            this.DetallePedido = new HashSet<DetalleModel>();
        }

        public int Id_Pedido { get; set; }
        public int Id_Cliente { get; set; }
        public string Descripción { get; set; }
        public string Dirección { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaHora { get; set; }
        public decimal Total { get; set; }
        public string TelefonoContacto { get; set; }
        public string Retiro { get; set; }
        public virtual ClienteModel Cliente { get; set; }
        public virtual ICollection<FacturaModel> Factura { get; set; }
        public virtual ICollection<DetalleModel> DetallePedido { get; set; }
    }
}
