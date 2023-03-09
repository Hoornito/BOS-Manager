using Microsoft.EntityFrameworkCore;

using SL.Services.Extensions;
using SL.Settings;

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
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public AppDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }
        /// <summary>
        /// Configura la conexion a la base de datos
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-HOT45OL;Initial Catalog=BOSDB;Integrated Security=True");
                optionsBuilder.UseSqlServer(ApplicationSettings.SQLPath);
                //base.OnConfiguring(optionsBuilder);
            }

        }
        /// <summary>
        /// Configura las entidades
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly)
                .SetPropertyDefaultSqlValue("CreateDate", "getdate()")
                .SetPropertyDefaultValue<bool>("Active", true)
                .SetPropertyQueryFilter("Active", true);
        }
        /// <summary>
        /// Guarda los cambios
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            SetUpdateDateOnModifiedEntries();
            return base.SaveChanges();
        }
        /// <summary>
        /// Guarda los cambios de forma asincrona
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetUpdateDateOnModifiedEntries();
            return base.SaveChangesAsync(cancellationToken);
        }
        /// <summary>
        /// Actualiza la fecha de modificacion
        /// </summary>
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
