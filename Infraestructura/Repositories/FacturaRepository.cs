using Contratos.Repositories;

using Domain.Models;

namespace Infraestructura.Repositories
{
    public class FacturaRepository : GenericRepository<FacturaModel>, IFacturaRepository
    {
        public FacturaRepository(AppDBContext context) : base(context)
        {

        }
    }
}
