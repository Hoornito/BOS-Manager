using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Services
{
    public partial interface IGenericService<T> where T : class
    {
        void Insertar(T entities);

        void Actualizar(T entities);

        void Eliminar(T entities);

        IEnumerable<T> GetAll();

        T GetById(object id);

        void CancelChanges(T entity);

        IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            bool ignoreQueryFilters = false,
            bool tracking = true);

        T GetOne(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            bool ignoreQueryFilters = false);

        void Eliminar(List<T> entities);
    }
}
