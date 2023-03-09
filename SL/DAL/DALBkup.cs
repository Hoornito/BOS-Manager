using Microsoft.Data.SqlClient;

using SL.Settings;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL
{
    class DALBkup
    {

        #region singleton
        private readonly static DALBkup _instance = new DALBkup();

        public static DALBkup Current
        {
            get
            {
                return _instance;
            }
        }

        private DALBkup()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        /// <summary>
        /// Genera una copia de seguridad de la base de datos.
        /// </summary>
        public void GenerateBackup()
        {
            string command = ApplicationSettings.BackUp;

            SqlConnection conexion = new SqlConnection(ApplicationSettings.SQLPath);
            SqlCommand cmd = new SqlCommand(command, conexion);
            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }

    }
}
