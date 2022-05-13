using Domain.Entities;

using System.Collections.Generic;

namespace Contratos.Controllers
{
    public interface IClienteController
    {
        public void GuardarCambios(ClienteEntity clienteEntity);

        public List<ClienteEntity> GetAll();

        public ClienteEntity GetCliente(string telefono);
    }
}
