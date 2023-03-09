using Domain.Entities;

using System.Collections.Generic;

namespace Contratos.Controllers
{
    public interface IClienteController
    {
        /// <summary>
        /// Metodo para guardar cambios
        /// </summary>
        /// <param name="clienteEntity"></param>
        public void GuardarCambios(ClienteEntity clienteEntity);
        /// <summary>
        /// Metodo para obtener todos los clientes
        /// </summary>
        /// <returns></returns>
        public List<ClienteEntity> GetAll();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="telefono"></param>
        /// <returns></returns>
        public ClienteEntity GetCliente(string telefono);
    }
}
