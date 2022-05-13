using Microsoft.EntityFrameworkCore;

using System;

namespace Domain.Entities
{
    public class FacturaEntity
    {

        public FacturaEntity(EntityState state = EntityState.Unchanged)
        {
            State = state;
        }

        public FacturaEntity(string baseImponible, decimal iva, string ivaDiscriminado, DateTime fechaYHora, int id_Pedido) : this()
        {
            BaseImponible = baseImponible;
            FechaYHora = fechaYHora;
            IVA = iva;
            IVADiscriminado = ivaDiscriminado;
            Id_Pedido = id_Pedido;
        }

        public FacturaEntity(int id_Factura, string baseImponible, decimal iva, string ivaDiscriminado, DateTime fechaYHora, int id_Pedido) : this(baseImponible, iva, ivaDiscriminado, fechaYHora, id_Pedido)
        {
            Id_Factura = id_Factura;
        }

        public int Id_Factura { get; set; }
        public string BaseImponible { get; set; }
        public int Id_Pedido { get; set; }
        //public double Descuento { get; set; }
        public DateTime FechaYHora { get; set; }
        public decimal IVA { get; set; }
        public string IVADiscriminado { get; set; }
        public EntityState State { get; set; }
    }
}
