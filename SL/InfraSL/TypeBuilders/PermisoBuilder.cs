using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.InfraSL.TypeBuilders
{
    public class PermisoBuilder : IEntityTypeConfiguration<PermisoModel>
    {
        public void Configure(EntityTypeBuilder<PermisoModel> builder)
        {
            builder.HasKey(p => p.id);

            builder.Property(p => p.nombre)
                .IsRequired(true);

            builder.Property(p => p.permiso)
                .IsRequired(false);


            builder.ToTable("permiso");
        }
    }
}