using SL.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL
{
    public sealed class BLLBkup
    {
        #region singleton
        private readonly static BLLBkup _instance = new BLLBkup();

        public static BLLBkup Current
        {
            get
            {
                return _instance;
            }
        }

        private BLLBkup()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public void GenerateBackup()
        {
            DALBkup.Current.GenerateBackup();
        }
    }
}
