using Microsoft.EntityFrameworkCore;

using System;

namespace Domain.Entities
{
    public class DetalleEntity
    {

        public DetalleEntity(EntityState state = EntityState.Unchanged)
        {
            State = state;
        }

        public DetalleEntity(string tipo, string nombre, int cantidad, decimal precioUnidad, int id_Pedido, Guid id_Product, decimal subtotal) : this()
        {
            Tipo = tipo;
            Nombre = nombre;
            Cantidad = cantidad;
            PrecioUnidad = precioUnidad;
            Id_Pedido = id_Pedido;
            Id_Producto = id_Product;
            SubTotal = subtotal;
        }

        public DetalleEntity(int id_Detalle, string tipo,string nombre, int cantidad, decimal precioUnidad, int id_Pedido, Guid id_Product, decimal subtotal) : this(tipo, nombre, cantidad, precioUnidad, id_Pedido, id_Product, subtotal)
        {
            Id_Detalle = id_Detalle;
        }
        public int Cantidad { get; set; }
        public string Tipo { get; set; }
        public int Id_Detalle { get; set; }
        public decimal PrecioUnidad { get; set; }
        public Guid Id_Producto { get; set; }
        public string Nombre { get; set; }
        public int Id_Pedido { get; set; }
        public EntityState State { get; set; }
        public decimal SubTotal { get; set; }
    }
}
