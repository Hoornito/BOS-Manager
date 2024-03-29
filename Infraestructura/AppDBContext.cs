﻿using Microsoft.EntityFrameworkCore;

using SL.Services.Extensions;

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {

        }

        public AppDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-HOT45OL;Initial Catalog=BOSDB;Integrated Security=True");
                //base.OnConfiguring(optionsBuilder);
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly)
                .SetPropertyDefaultSqlValue("CreateDate", "getdate()")
                .SetPropertyDefaultValue<bool>("Active", true)
                .SetPropertyQueryFilter("Active", true);
        }

        public override int SaveChanges()
        {
            SetUpdateDateOnModifiedEntries();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetUpdateDateOnModifiedEntries();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetUpdateDateOnModifiedEntries()
        {
            var modifiedEntries = ChangeTracker
                .Entries()
                .Where(e => e.Metadata.FindProperty("UpdateDate") != null &&
                            e.State == EntityState.Modified);

            foreach (var modifiedEntry in modifiedEntries)
            {
                modifiedEntry.Property("UpdateDate").CurrentValue = DateTime.Now;
            }
        }
    }
}
