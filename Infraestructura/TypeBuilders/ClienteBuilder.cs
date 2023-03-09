using Domain.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.TypeBuilders
{
    public class ClienteBuilder : IEntityTypeConfiguration<ClienteModel>
    {
        /// <summary>
        /// Configuracion de la tabla Cliente
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.HasKey(p => p.Id_Cliente);

            builder.Property(p => p.DNI)
                .IsRequired(false);

            builder.Property(p => p.Nombre)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Property(p => p.Active)
                .IsRequired(true);

            builder.Property(p => p.Dirección)
                .IsRequired(true);

            builder.Property(p => p.MailContacto)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.Property(p => p.Teléfono)
                .IsRequired(true);

            builder.ToTable("Cliente");
        }
    }
}
