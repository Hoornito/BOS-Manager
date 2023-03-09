using Domain.Models;

namespace Contratos.Services
{
    public interface IReporteService : IGenericService<ReporteModel>
    {
        /// <summary>
        /// Genera reporte de ventas
        /// </summary>
        public void GenerateMonthlyReport();

        /// <summary>
        /// genera reporte de excel de pedidos
        /// </summary>
        public void GenerateExcelReport();
    }
}
