using Domain.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.TypeBuilders
{
    public class DetalleBuilder : IEntityTypeConfiguration<DetalleModel>
    {
        public void Configure(EntityTypeBuilder<DetalleModel> builder)
        {
            builder.HasKey(p => p.Id_Detalle);

            builder.HasOne(p => p.Pedido)
                .WithMany(p => p.DetallePedido)
                .HasForeignKey(p => p.Id_Pedido);

            builder.HasOne(p => p.Producto)
                .WithMany(p => p.DetallePedido)
                .HasForeignKey(p => p.Id_Producto);

            builder.Property(p => p.Cantidad)
                .IsRequired(true);

            builder.ToTable("DetallePedido");
        }
    }
}
