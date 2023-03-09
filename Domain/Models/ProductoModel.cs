using System.Collections.Generic;

namespace Domain.Models
{
    public class ProductoModel
    {


        public ProductoModel()
        {
            this.DetallePedido = new HashSet<DetalleModel>();
        }

        public System.Guid Id_Producto { get; set; }
        public string Descripción { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int Cantidad { get; set; }
        public string Tipo { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<DetalleModel> DetallePedido { get; set; }
    }
}
