using Domain.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.TypeBuilders
{
    public class ProductoBuilder : IEntityTypeConfiguration<ProductoModel>
    {
        public void Configure(EntityTypeBuilder<ProductoModel> builder)
        {
            builder.HasKey(p => p.Id_Producto);

            builder.HasMany(p => p.DetallePedido)
                .WithOne(p => p.Producto)
                .HasForeignKey(p => p.Id_Producto);

            builder.Property(p => p.Descripción)
                .IsRequired(false);

            builder.Property(p => p.Nombre)
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property(p => p.PrecioUnidad)
                .IsRequired(true);

            builder.Property(p => p.Cantidad)
                .IsRequired(true);

            builder.Property(p => p.Active)
                .IsRequired(true);

            builder.ToTable("Producto");
        }
    }
}
