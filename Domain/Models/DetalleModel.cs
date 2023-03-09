namespace Domain.Models
{
    public class DetalleModel
    {
        public int Id_Pedido { get; set; }
        public System.Guid Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public int Id_Detalle { get; set; }
        public string Tipo { get; set; }

        public virtual PedidoModel Pedido { get; set; }
        public virtual ProductoModel Producto { get; set; }
    }
}
