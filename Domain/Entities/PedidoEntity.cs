using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class PedidoEntity
    {
        public PedidoEntity(EntityState state = EntityState.Unchanged)
        {
            State = state;
        }

        public PedidoEntity(int id_Cliente, string descripción, string dirección, string estado, DateTime fechaHora, decimal total, string telefonoContacto, string nombreCliente) : this()
        {
            Id_Cliente = id_Cliente;
            Descripción = descripción;
            Estado = estado;
            FechaHora = fechaHora;
            Total = total;
            TelefonoContacto = telefonoContacto;
            Dirección = dirección;
            NombreCliente = nombreCliente;
        }

        public PedidoEntity(int id_Pedido, int id_Cliente, string descripción, string dirección, string estado, DateTime fechaHora, decimal total, string telefonoContacto, string nombreCliente) : this(id_Cliente, descripción, dirección, estado, fechaHora, total, telefonoContacto, nombreCliente)
        {
            Id_Pedido = id_Pedido;
        }

        public int Cantidad { get; set; }
        public int Id_Cliente { get; set; }

        public int Id_Pedido { get; set; }
        public string NombreCliente { get; set; }
        public string Retiro { get; set; }
        public string Descripción { get; set; }

        //nombre de producto - cantidad
        //public Dictionary<string, int> Detalle { get; set; }
        //public List<DetalleEntity> detalles { get; set; }
        public string Dirección { get; set; }
        public string Estado { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Total { get; set; }
        public string Responsable { get; set; }
        public string TelefonoContacto { get; set; }

        public EntityState State { get; set; }
    }
}
