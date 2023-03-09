using SL.Services.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Tools.LanguageManager
{
    public class TranducirForm
    {
        #region singleton

        private readonly static TranducirForm _instance = new TranducirForm();

        public static TranducirForm Current
        {
            get
            {
                return _instance;
            }
        }

        private TranducirForm()
        {
            //Implent here the initialization of your singleton
        }

        #endregion

        /// <summary>
        /// traduce el formulario
        /// </summary>
        /// <param name="form"></param>
        public void TraducirFormulario(Form form)
        {
            try
            {
                foreach (Control controlForm in form.Controls)
                {
                    RecorrerControl(controlForm);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// recorre el control para luego ser traducido
        /// </summary>
        /// <param name="control"></param>
        private void RecorrerControl(Control control)
        {
            string palabra;
            int v = 0;
            foreach (Control controlInControl in control.Controls)
            {
                v = 1;
                RecorrerControl(controlInControl);
            }
            if (v == 0)
            {
                palabra = control.Text.Traducir();
                control.Text = palabra;
            }
        }

        /// <summary>
        /// traduce el control
        /// </summary>
        /// <param name="control"></param>
        public static void TraducirControl(Control control)
        {
            PropertyInfo TextControl;
            string PalabraTraducida;
            TextControl = control.GetType().GetProperty("Text");

            if (!(TextControl.GetValue(control).ToString() == "" || TextControl.GetValue(control).ToString() == null))
            {
                PalabraTraducida = control.Text.Traducir();
                control.Text = PalabraTraducida;
            }
        }

        /// <summary>
        /// selecciona el idioma
        /// </summary>
        /// <param name="idioma"></param>
        public void SeleccionarIdioma(string idioma)
        {
            idioma.SeleccionarIdioma();
        }
    }
}
