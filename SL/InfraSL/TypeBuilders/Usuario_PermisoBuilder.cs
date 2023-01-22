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
    public class Usuario_PermisoBuilder : IEntityTypeConfiguration<Usuario_PermisoModel>
    {
        public void Configure(EntityTypeBuilder<Usuario_PermisoModel> builder)
        {
            builder.HasKey(p => new { p.id_permiso, p.id_usuario });

            builder.HasOne(p => p.UsuarioModel)
                   .WithMany(p => p.Usuario_Permisos)
                   .HasForeignKey(p => p.id_usuario);

            builder.HasOne(p => p.PermisoModel)
                   .WithMany(p => p.Usuario_Permisos)
                   .HasForeignKey(p => p.id_permiso);

            builder.ToTable("usuarios_permisos");
        }
    }
}
