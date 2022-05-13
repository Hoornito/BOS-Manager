using SL.Services.Extensions;
using SL.Settings;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SL.DAL
{
     internal sealed class DALLangugage
     {
        #region Singleton
        private readonly static DALLangugage _instance = new DALLangugage();

        private string filePath;

        public static DALLangugage Current
        {
            get
            {
                return _instance;
            }
        }

        private DALLangugage()
        {
            //Implement here the initialization code
            filePath = ApplicationSettings.IdiomaPath;
        }
        #endregion

        public string Traducir(string clave)
        {
            string codigoCultura = Thread.CurrentThread.CurrentUICulture.Name;

            string palabraTraducida = clave;

            using (StreamReader streamReader = new StreamReader(filePath + codigoCultura))
            {
                while (!streamReader.EndOfStream)
                {
                    string linea = streamReader.ReadLine();
                    string[] keyValuePair = linea.Split(';');

                    if (keyValuePair[0].ToLower() == clave.ToLower())
                    {
                        palabraTraducida = keyValuePair[1];
                        break;
                    }
                }
            }
            return palabraTraducida;
        }

     }
}
