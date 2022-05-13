using Contratos.Repositories;

using Domain.Models;

namespace Infraestructura.Repositories
{
    public class HistoricoRepository : GenericRepository<HistoricoModel>, IHistoricoRepository
    {
        public HistoricoRepository(AppDBContext context) : base(context)
        {

        }
    }
}
