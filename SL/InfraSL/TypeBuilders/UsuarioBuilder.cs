using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.InfraSL.TypeBuilders
{
    public class UsuarioBuilder : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(p => p.id_usuario);

            builder.Property(p => p.usuario)
                .IsRequired(true)
                .HasColumnType("nvarchar(50)");

            builder.Property(p => p.pw)
                .IsRequired(true)
                .HasColumnType("nvarchar(90)");

            builder.Property(p => p.nombre)
                .IsRequired(false)
                .HasColumnType("nvarchar(50)");

            builder.Property(p => p.apellido)
                .IsRequired(false)
                .HasColumnType("nvarchar(50)");

            builder.Property(p => p.email)
                .IsRequired(false)
                .HasColumnType("nvarchar(50)");

            builder.Property(p => p.telefono)
                .IsRequired(false)
                .HasColumnType("nvarchar(50)");

            builder.Property(p => p.dni)
                .IsRequired(false)
                .HasColumnType("nvarchar(50)");

            builder.Property(p => p.idioma)
                .IsRequired(false)
                .HasColumnType("nvarchar(50)");

            builder.ToTable("usuarios");
        }
    }
}
