using AutoMapper;

using Contratos.Controllers;
using Contratos.Services;

using SL.Contratos.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class ReporteController : IReporteController
    {
        private readonly IReporteService _reporteService;
        private readonly IMapper _mapper;

        public ReporteController(IReporteService reporteService, IMapper mapper)
        {
            _reporteService = reporteService;
            _mapper = mapper;
        }
        /// <summary>
        /// genera el reporte mensual
        /// </summary>
        public void GenerarReporteMensual()
        {
            _reporteService.GenerateMonthlyReport();
        }
        /// <summary>
        /// genera un excel con el reporte mensual de ventas
        /// </summary>
        public void GenerateExcelReport()
        {
            _reporteService.GenerateExcelReport();
        }
    }
}
