using SL.DAL;
using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL
{
    public sealed class BLLLogin
    {
        #region singleton
        private readonly static BLLLogin _instance = new BLLLogin();

        public static BLLLogin Current
        {
            get
            {
                return _instance;
            }
        }

        private BLLLogin()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public bool Verify(UsuarioEntity data)
        {
            if (DALLogin.Current.Verify(data) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
