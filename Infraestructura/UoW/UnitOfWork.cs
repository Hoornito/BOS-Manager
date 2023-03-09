using Contratos.Repositories;

using SL.Services.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Infraestructura.UoW
{
    public class UnitOfWork : UnitOfWorkBase, IUnitOfWork
    {
        private List<Type> _repositories;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public UnitOfWork(AppDBContext context) : base(context)
        {
            InitializeRepositories();
        }
        /// <summary>
        /// Obtiene el repositorio
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <returns></returns>
        public I GetRepository<I>()
        {
            var repository = _repositories.FirstOrDefault(t => typeof(I).IsAssignableFrom(t));
            return (I)Activator.CreateInstance(repository, Context);
        }

        /// <summary>
        /// Inicializa los repositorios
        /// </summary>
        private void InitializeRepositories()
        {
            _repositories = new List<Type>();
            var genericType = typeof(IGenericRepository<>).GetGenericTypeDefinition();
            foreach (var iRepository in genericType.Assembly.GetTypes(t => t.IsInterface && t.ImplementsGenericInterface(genericType)))
            {
                var repository = this.GetType().Assembly.FindType(t => t.IsClass && iRepository.IsAssignableFrom(t));
                _repositories.Add(repository);
            }
        }
    }
}
