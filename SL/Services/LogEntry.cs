using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Severity { get; set; }
        public string Message { get; set; }
    }
}
