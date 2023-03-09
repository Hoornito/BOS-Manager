using Domain.Models;

namespace Contratos.Services
{
    public interface IClienteService : IGenericService<ClienteModel>
    {
        /// <summary>
        /// Crea un cliente
        /// </summary>
        /// <param name="cliente"></param>
        public void CrearCliente(ClienteModel cliente);

        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="cliente"></param>
        public void ActualizarCliente(ClienteModel cliente);

        /// <summary>
        /// Elimina un cliente
        /// </summary>
        /// <param name="clienteModel"></param>
        public void EliminarCliente(ClienteModel clienteModel);
    }
}
