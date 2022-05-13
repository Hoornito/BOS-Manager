using Contratos.Repositories;

using Domain.Models;

namespace Infraestructura.Repositories
{
    public class ClienteRepository : GenericRepository<ClienteModel>, IClienteRepository
    {
        public ClienteRepository(AppDBContext context) : base(context)
        {

        }
    }
}
