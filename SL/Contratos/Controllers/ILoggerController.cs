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
        public List<LogEntry> GetLog();
        public List<LogEntry> LogFilter(DateTime date, string severity);
    }
}
