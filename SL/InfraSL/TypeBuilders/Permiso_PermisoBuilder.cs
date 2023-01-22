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
    public class Permiso_PermisoBuilder : IEntityTypeConfiguration<Permiso_PermisoModel>
    {
        public void Configure(EntityTypeBuilder<Permiso_PermisoModel> builder)
        {
            builder.HasKey(p => p.id_permiso_permiso);

            builder.Property(p => p.id_permiso_hijo)
                .IsRequired(false)
                .HasColumnType("int");
            
            builder.Property(p => p.id_permiso_padre)
                .IsRequired(false)
                .HasColumnType("int");

            builder.ToTable("permiso_permiso");
        }
    }
}
