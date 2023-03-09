using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Controllers
{
    public interface IReporteController 
    {
        /// <summary>
        /// genera un reporte mensual
        /// </summary>
        public void GenerarReporteMensual();

        /// <summary>
        /// genera un reporte en excel
        /// </summary>
        public void GenerateExcelReport();
    }
}
