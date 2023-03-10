using Domain.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.TypeBuilders
{
    public class PedidoBuilder : IEntityTypeConfiguration<PedidoModel>
    {
        /// <summary>
        /// Configuracion de la tabla Pedido
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<PedidoModel> builder)
        {
            builder.HasKey(p => p.Id_Pedido);
            builder.Property(p => p.Id_Pedido).ValueGeneratedNever();

            builder.HasMany(p => p.Factura)
                .WithOne(p => p.Pedido)
                .HasForeignKey(p => p.Id_Pedido);

            //builder.HasOne(p => p.Cliente)
            //    .WithMany(p => p.Pedido)
            //    .IsRequired(false);

            builder.Property(p => p.Id_Cliente)
                .IsRequired(false);

            builder.HasMany(p => p.DetallePedido)
                .WithOne(p => p.Pedido)
                .HasForeignKey(p => p.Id_Pedido);

            builder.Property(p => p.Dirección)
                .IsRequired(false);

            builder.Property(p => p.TelefonoContacto)
                .IsRequired(false);

            builder.Property(p => p.Descripción)
                .IsRequired(false);

            builder.Property(p => p.Retiro)
                .IsRequired(false);

            builder.Property(p => p.FechaHora)
                .IsRequired(true);

            builder.Property(p => p.Estado)
                .IsRequired(true);

            builder.Property(p => p.Total)
                /*.IsRequired(false)*/;

            builder.ToTable("Pedido");
        }
    }
}
