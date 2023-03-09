using Domain.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.TypeBuilders
{
    public class FacturaBuilder : IEntityTypeConfiguration<FacturaModel>
    {
        /// <summary>
        /// Configuracion de la tabla Factura
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<FacturaModel> builder)
        {
            builder.HasKey(p => p.Id_Factura);

            builder.HasOne(p => p.Pedido)
                .WithMany(p => p.Factura)
                .HasForeignKey(p => p.Id_Pedido);

            builder.Property(p => p.IVA)
                .IsRequired(true);

            builder.Property(p => p.BaseImponible)
                .IsRequired(true);

            builder.Property(p => p.IVADiscriminado)
                .IsRequired(true);

            builder.Property(p => p.FechaYHora)
                .IsRequired(true);

            builder.ToTable("Factura");
        }
    }
}
