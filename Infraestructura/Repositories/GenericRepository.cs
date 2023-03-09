using Contratos.Repositories;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infraestructura.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region Fields
        /// <summary>
        /// The database context used by the repository.
        /// </summary>
        internal AppDBContext _context;

        /// <summary>
        /// The entities in the database set.
        /// </summary>
        internal DbSet<T> _entities;

        #endregion Fields

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{T}"/> class.
        /// </summary>
        /// <param name="context">The database context used by the repository.</param>
        public GenericRepository(AppDBContext context)
        {
            this._context = context;
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Gets the database queryable.
        /// </summary>
        public virtual IQueryable<T> Table => this.Entities;

        /// <summary>
        /// Gets the database queryable without tracking changes.
        /// </summary>
        public virtual IQueryable<T> TableNoTracking => this.Entities.AsNoTracking();

        /// <summary>
        /// Gets or sets the entities in the database set.
        /// </summary>
        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Gets the entity with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the entity to get.</param>
        /// <returns>The entity with the specified ID.</returns>
        public virtual T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        /// <summary>
        /// Inserts the specified entity into the database set.
        /// </summary>
        /// <param name="entities">The entity to insert.</param>
        public void Insert(T entities)
        {
            this.Entities.Add(entities);
        }

        /// <summary>
        /// Updates the specified entity in the database set.
        /// </summary>
        /// <param name="entities">The entity to update.</param>
        public void Update(T entities)
        {
            //var local = _context.Set<entities>().Local.FirstOrDefault(entry => entry.Id.Equals(entry.Id));

            //if (local != null)
            //{
            //    _context.Entry(local).State = EntityState.Detached;
            //}
            //this._context.Entry(entities).State = EntityState.Detached;
            this._context.Entry(entities).State = EntityState.Modified;
        }

        /// <summary>
        /// Deletes the specified entity from the database set.
        /// </summary>
        /// <param name="entities">The entity to delete.</param>
        public void Delete(T entities)
        {
            this._context.Entry(entities).State = EntityState.Deleted;
        }

        /// <summary>
        /// Gets the entities that match the specified filter and include properties.
        /// </summary>
        /// <param name="filter">The filter to apply to the entities.</param>
        /// <param name="orderBy">The order to apply to the entities.</param>
        /// <param name="includeProperties">The properties to include in the entities.</param>
        /// <param name="ignoreQueryFilters">Whether to ignore the query filters in the entities.</param>
        /// <param name="tracking">Whether to track changes to the entities.</param>
        /// <returns>The entities that match the specified filter and include properties.</returns>
        public virtual IEnumerable<T> Get(
                Expression<Func<T, bool>> filter = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                string includeProperties = "",
                bool ignoreQueryFilters = false,
                bool tracking = true)
        {
            IQueryable<T> query = tracking ? this.Entities : this.Entities.AsNoTracking();

            if (ignoreQueryFilters)
            {
                query = query.IgnoreQueryFilters();
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (string includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty.Trim());
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        public T GetOne(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            bool ignoreQueryFilters = false)
        {
            var result = Get(filter, orderBy, includeProperties, ignoreQueryFilters);
            return result.FirstOrDefault();
        }


        public virtual void CancelChanges(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            this._context.Entry(entity).State = EntityState.Unchanged;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion Methods
    }
}
