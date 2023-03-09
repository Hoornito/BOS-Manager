using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Contratos.Services
{
    public partial interface IGenericService<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        void Insertar(T entities);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        void Actualizar(T entities);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        void Eliminar(T entities);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(object id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void CancelChanges(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <param name="ignoreQueryFilters"></param>
        /// <returns></returns>
        IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            bool ignoreQueryFilters = false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <param name="ignoreQueryFilters"></param>
        /// <returns></returns>
        T GetOne(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            bool ignoreQueryFilters = false);

    }
}
