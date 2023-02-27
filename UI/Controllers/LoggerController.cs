using Microsoft.VisualBasic;

using SL.Contratos.Controllers;
using SL.Services;
using SL.Settings;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

using static System.Windows.Forms.LinkLabel;

namespace UI.Controllers
{
    public class LoggerController : ILoggerController
    {
        private readonly string _logPath = "C:\\Users\\agusf\\source\\repos\\BOS Manager\\UI\\bin\\Debug\\LoggerManager.txt";
        public List<LogEntry> GetLog()
        {
            List<LogEntry> logEntries = new List<LogEntry>();

            using (var streamReader = new StreamReader(_logPath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    LogEntry entry = ParseLogLine(line);
                    logEntries.Add(entry);
                }
                return logEntries;
            }               
        }
        
        private static LogEntry ParseLogLine(string line)
        {
            var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var timestamp = DateTime.Parse(parts[0] + " " + parts[1].Substring(0, parts[1].Length - 4));
            var severity = parts[3];
            var message = string.Join(" ", parts.Skip(8));
            return new LogEntry { Timestamp = timestamp, Severity = severity, Message = message };
        }

        public List<LogEntry> LogFilter(DateTime date, string severity)
        {
            if (severity == string.Empty || severity == null || severity == "Todos")
            {
                return GetLog().Where(entry => entry.Timestamp.Date == date.Date).ToList();
            }
            else
            {
                return GetLog().Where(entry => entry.Timestamp.Date == date.Date && entry.Severity == severity).ToList();
            }
        }
    }
}
