using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Repositories.SqlServer.Adapters
{
    public class GenericSLAdapter
    {
        #region singleton
        private readonly static GenericSLAdapter _instance = new GenericSLAdapter();

        public static GenericSLAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private GenericSLAdapter()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public object PropertiesFromType(string pAssembly, string oClass, object[] Values)
        {
            if (oClass == null)
            {

            }
            Assembly ensamblado = Assembly.LoadFrom(pAssembly);
            Type t = ensamblado.GetType(oClass);
            PropertyInfo[] props = t.GetProperties();
            object item = Activator.CreateInstance(t);
            int i = 0;
            foreach (PropertyInfo prp in props)
            {
                prp.SetValue(item, Values[i], null);
                i++;
            }
            return item;
        }

    }
}
