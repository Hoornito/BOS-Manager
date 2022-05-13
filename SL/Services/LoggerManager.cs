using log4net;

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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly log4net.ILog logPerformance = log4net.LogManager.GetLogger("performance");



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

        public static void Info(string message)
        {
            log.Info(message);
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
