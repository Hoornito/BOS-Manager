using Contratos.Repositories;
using Contratos.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BLL.Services
{
    public abstract class GenericService<T> : IGenericService<T> where T : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IGenericRepository<T> _repository;
        public GenericService(IUnitOfWork unitOfWork,
            IGenericRepository<T> repository)
        {
            this._unitOfWork = unitOfWork;
            this._repository = repository;
        }

        public void Insertar(T entities)
        {
            _repository.Insert(entities);
            //_unitOfWork.Save();
        }

        public void Actualizar(T entities)
        {
            _repository.Update(entities);
            //_unitOfWork.Save();
        }

        public void CancelChanges(T entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(T entities)
        {
            _repository.Delete(entities);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool ignoreQueryFilters = false)
        {
            var result = _repository.Get(filter, orderBy, includeProperties, ignoreQueryFilters);
            return result;
        }


        public T GetById(object id)
        {
            return _repository.GetById(id);
        }

        public T GetOne(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool ignoreQueryFilters = false)
        {
            //return _repository.GetOne(filter, orderBy, includeProperties, ignoreQueryFilters);
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.TableNoTracking.AsEnumerable<T>();
        }
    }
}
