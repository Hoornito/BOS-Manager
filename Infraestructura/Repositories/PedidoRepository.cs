using Contratos.Repositories;

using Domain.Models;

namespace Infraestructura.Repositories
{
    public class PedidoRepository : GenericRepository<PedidoModel>, IPedidoRepository
    {
        public PedidoRepository(AppDBContext context) : base(context)
        {

        }
    }

}
