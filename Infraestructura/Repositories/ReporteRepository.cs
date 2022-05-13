using Contratos.Repositories;

using Domain.Models;

namespace Infraestructura.Repositories
{
    public class ReporteRepository : GenericRepository<ReporteModel>, IReporteRepository
    {
        public ReporteRepository(AppDBContext context) : base(context)
        {

        }
    }
}
