using log4net;
using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;

using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SL.Services
{
    public static class LoggerManager
    {
        private static readonly ILog log = log4net.LogManager.GetLogger("LoggerManager");
        private static readonly ILog logtest = LogManager.GetLogger("LoggerManager");
        private static readonly ILog logPerformance = LogManager.GetLogger("performance");




        /// <summary>
        /// Genera un registro de log de un error ocurrido en la aplicación.
        /// </summary>
        /// <param name="ex">La excepción que se desea registrar.</param>
        public static void GenerateLog(Exception ex)
        {
            try
            {
                log.Error(ex);
            }
            catch
            {

            }
        }

        /// <summary>
        /// Registra un mensaje de información en el registro de log de la aplicación.
        /// </summary>
        /// <param name="message">El mensaje que se desea registrar.</param>
        public static void Info(string message)
        {
            log.Info(message);
        }

        /// <summary>
        /// Registra un mensaje de error en el registro de log de la aplicación.
        /// </summary>
        /// <param name="message">El mensaje que se desea registrar.</param>
        public static void Error(string message)
        {
            log.Error(message);
        }

        /// <summary>
        /// Registra un mensaje de advertencia en el registro de log de la aplicación.
        /// </summary>
        /// <param name="message">El mensaje que se desea registrar.</param>
        public static void Warn(string message)
        {
            log.Warn(message);
        }

        //#region singleton

        //private readonly static LoggerManager _instance = new LoggerManager();

        //public static LoggerManager Current
        //{
        //    get
        //    {
        //        return _instance;
        //    }
        //}
        ////private string FILEPATH = String.Empty;
        //private LoggerManager()
        //{
        //    //AGREGAR FILEPATH
        //}

        //#endregion 
        //private string filePath = String.Empty;
        //public void Write(string message, EventLevel eventLevel)
        //{
        //    switch (eventLevel)
        //    {
        //        case EventLevel.Error:
        //            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
        //            {
        //                streamWriter.WriteLine($"{DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") } [Severity { eventLevel.ToString() }] : { message }");
        //            }
        //            break;

        //        case EventLevel.Critical:
        //            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
        //            {
        //                streamWriter.WriteLine($"{DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") } [Severity { eventLevel.ToString() }] : { message }");
        //            }
        //            break;

        //        case EventLevel.Informational:
        //            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
        //            {
        //                streamWriter.WriteLine($"{DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") } [Severity { eventLevel.ToString() }] : { message }");
        //            }
        //            break;
        //    }
        //}
    }
}
