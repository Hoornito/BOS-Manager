using Domain.Models;

namespace Contratos.Services
{
    public interface IClienteService : IGenericService<ClienteModel>
    {
        public void CrearCliente(ClienteModel cliente);

        public void ActualizarCliente(ClienteModel cliente);

        public void EliminarCliente(ClienteModel clienteModel);
    }
}
