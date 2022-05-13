using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Contratos.Repositories
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        void Insert(T entities);

        void Update(T entities);

        void Delete(T entities);

        void CancelChanges(T entity);

        T GetById(object id);


        /// <summary>
        /// Devuelve una lista acorde al filtro y orden especificados. La ejecución del
        /// query sobre la base de datos depende de la acción que se realice sobre la lista
        /// que devuelve este método (para más información ver: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/classification-of-standard-query-operators-by-manner-of-execution
        /// </summary>
        /// <param name="filter">Predicado para filtrar los registros</param>
        /// <param name="orderBy">Indica de qué manera se deben ordenar los registros</param>
        /// <param name="includeProperties">Propiedades a incluir, esto genera operaciones join con otras tablas</param>
        /// <param name="ignoreQueryFilters">Se usa para ignorar filtros por defecto en la configuración del DBContext</param>
        /// <returns>Un IEnumerable de elementos del tipo T</returns>
        /// 
        IEnumerable<T> Get(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                string includeProperties = "",
                bool ignoreQueryFilters = false,
                bool tracking = true);


        /// <summary>
        /// Busca un registro acorde al filtro y orden especificados.
        /// </summary>
        /// <param name="filter">Predicado para filtrar los registros</param>
        /// <param name="orderBy">Indica de qué manera se deben ordenar los registros</param>
        /// <param name="includeProperties">Propiedades a incluir, esto genera operaciones join con otras tablas</param>
        /// <param name="ignoreQueryFilters">Se usa para ignorar filtros por defecto en la configuración del DBContext</param>
        /// <returns>El primer elemento que se encuentre, null si no hay resultados</returns>
        T GetOne(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            bool ignoreQueryFilters = false);



        IQueryable<T> Table { get; }

        IQueryable<T> TableNoTracking { get; }


    }
}
