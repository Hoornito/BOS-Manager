using Microsoft.Data.SqlClient;

using SL.Domain.Entities;
using SL.Settings;
using SL.Tools;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SL.DAL
{
    public sealed class DALLogin
    {
        #region singleton
        private readonly static DALLogin _instance = new DALLogin();

        public static DALLogin Current
        {
            get
            {
                return _instance;
            }
        }

        private DALLogin()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public bool Verify(UsuarioEntity data)
        {
            using (TransactionScope miTransaccion = new TransactionScope())
            {
                try
                {
                    bool Verify = SqlHelper.ExecuteNonQueryReturn(ApplicationSettings.StoredProcedure_Login, CommandType.StoredProcedure, new SqlParameter[] {
                                                                                                                    new SqlParameter("@nombre", data.nombre),
                                                                                                                    new SqlParameter("@pw", data.pw),
                                                                                                                    //new SqlParameter("@resultado", false)
                                                                                                                    });
                    miTransaccion.Complete();
                    return Verify;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}
