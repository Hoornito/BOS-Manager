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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="repository"></param>
        public GenericService(IUnitOfWork unitOfWork,
            IGenericRepository<T> repository)
        {
            this._unitOfWork = unitOfWork;
            this._repository = repository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        public void Insertar(T entities)
        {
            _repository.Insert(entities);
            //_unitOfWork.Save();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        public void Actualizar(T entities)
        {
            _repository.Update(entities);
            //_unitOfWork.Save();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void CancelChanges(T entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        public void Eliminar(T entities)
        {
            _repository.Delete(entities);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <param name="ignoreQueryFilters"></param>
        /// <returns></returns>        
        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool ignoreQueryFilters = false)
        {
            var result = _repository.Get(filter, orderBy, includeProperties, ignoreQueryFilters);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(object id)
        {
            return _repository.GetById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <param name="ignoreQueryFilters"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public T GetOne(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool ignoreQueryFilters = false)
        {
            //return _repository.GetOne(filter, orderBy, includeProperties, ignoreQueryFilters);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
        {
            return _repository.TableNoTracking.AsEnumerable<T>();
        }
    }
}
