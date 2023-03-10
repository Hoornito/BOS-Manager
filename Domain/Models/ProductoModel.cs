﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class ProductoModel
    {
        public ProductoModel()
        {
            this.DetallePedido = new HashSet<DetalleModel>();
        }
        [Key]
        public Guid Id_Producto { get; set; }
        public string Descripción { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int Cantidad { get; set; }
        public bool? Active { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<DetalleModel> DetallePedido { get; set; }
    }
}