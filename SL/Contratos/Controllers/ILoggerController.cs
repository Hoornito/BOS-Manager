using SL.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Controllers
{
    public interface ILoggerController
    {
        /// <summary>
        /// Obtiene el log
        /// </summary>
        /// <returns></returns>
        public List<LogEntry> GetLog();
        /// <summary>
        /// Filtra el log
        /// </summary>
        /// <param name="date"></param>
        /// <param name="severity"></param>
        /// <returns></returns>
        public List<LogEntry> LogFilter(DateTime date, string severity);
    }
}
