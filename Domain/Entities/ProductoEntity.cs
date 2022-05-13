using Microsoft.EntityFrameworkCore;

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ProductoEntity
    {
        public ProductoEntity(EntityState state = EntityState.Unchanged)
        {
            State = state;
        }

        public ProductoEntity(string nombre, string descripción, decimal precioUnidad, int cantidad) : this()
        {
            Nombre = nombre;
            Descripción = descripción;
            PrecioUnidad = precioUnidad;
            Cantidad = cantidad;
        }

        public ProductoEntity(Guid id_Producto, string nombre, string descripción, decimal precioUnidad, int cantidad) : this(nombre, descripción, precioUnidad, cantidad)
        {
            Id_Producto = id_Producto;
        }

        [Browsable(false)]
        public Guid Id_Producto { get; set; }


        public string Descripción { get; set; }

        [Required(ErrorMessage = "Nombre es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Precio por unidad es requerido.")]
        public decimal PrecioUnidad { get; set; }

        [Required(ErrorMessage = "Cantidad es requerida.")]
        public int Cantidad { get; set; }

        [Browsable(false)]
        public EntityState State { get; set; }

        public bool Active { get; set; }

    }
}
