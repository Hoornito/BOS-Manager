using Microsoft.Data.SqlClient;

using SL.Tools;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Repositories
{
    internal sealed class GenericCRUD
    {
        #region singleton
        private readonly static GenericCRUD _instance = new GenericCRUD();

        public static GenericCRUD Current
        {
            get
            {
                return _instance;
            }
        }

        private GenericCRUD()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public void Insert(string statement, object clase)
        {
            try
            {
                Type tipo = clase.GetType();
                PropertyInfo[] props = tipo.GetProperties();
                List<SqlParameter> parms = new List<SqlParameter>();

                foreach (PropertyInfo prp in props)
                {
                    var value = prp.GetValue(clase);
                    SqlParameter p = new SqlParameter("@" + prp.Name, value);
                    parms.Add(p);
                }
                SqlHelper.ExecuteNonQuery(statement, System.Data.CommandType.Text, parms.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
