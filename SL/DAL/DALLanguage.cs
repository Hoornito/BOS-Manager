using SL.InfraSL;
using SL.Services.Extensions;
using SL.Settings;

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
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
        private string CodigoCultura;

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
            CodigoCultura = ApplicationSettings.Culture;
        }
        #endregion

        public void SetCodigoCultura(string codigoCultura)
        {
            CodigoCultura = codigoCultura;
        }

        public string Traducir(string clave)
        {
            string palabraTraducida = clave;
            if(clave == "")
            {

            }
            else
            {
                using (StreamReader streamReader = new StreamReader(filePath + CodigoCultura))
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
            }
            return palabraTraducida;

        }

     }
}
