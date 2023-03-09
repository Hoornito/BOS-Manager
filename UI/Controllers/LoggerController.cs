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
        private readonly string _logPath = ApplicationSettings.Path;

        /// <summary>
        /// devuelve una lista de todas las entradas de registro almacenadas en el archivo de registro. Cada entrada de registro se lee del archivo de registro y se analiza mediante el método "ParseLogLine" para obtener la marca de tiempo, la gravedad y el mensaje, y luego se agrega a una lista de objetos "LogEntry" que se devuelve al final.
        /// </summary>
        /// <returns></returns>
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private static LogEntry ParseLogLine(string line)
        {
            var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var timestamp = DateTime.Parse(parts[0] + " " + parts[1].Substring(0, parts[1].Length - 4));
            var severity = parts[3];
            var message = string.Join(" ", parts.Skip(8));
            return new LogEntry { Timestamp = timestamp, Severity = severity, Message = message };
        }

        /// <summary>
        ///  toma una fecha y un nivel de gravedad como argumentos y devuelve una lista de entradas de registro que cumplen con los criterios de filtro. Si el nivel de gravedad es "Todos" o vacío, se devuelven todas las entradas de registro para la fecha especificada. De lo contrario, solo se devuelven las entradas de registro con la misma fecha y el nivel de gravedad especificado.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="severity"></param>
        /// <returns></returns>
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
