using Contratos.Repositories;

using Domain.Models;

namespace Infraestructura.Repositories
{
    public class DetalleRepository : GenericRepository<DetalleModel>, IDetalleRepository
    {
        public DetalleRepository(AppDBContext context) : base(context)
        {

        }
    }
}
