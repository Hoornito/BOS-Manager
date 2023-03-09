using SL.BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services
{
    internal sealed class LanguageManager
    {
        #region Singleton
        private readonly static LanguageManager _instance = new LanguageManager();

        public static LanguageManager Current
        {
            get
            {
                return _instance;
            }
        }

        private LanguageManager()
        {
            //Implement here the initialization code
        }
        #endregion


        //public string Traducir(string clave, Usuario usuario)
        //{
        //    usuario.IdiomaSeleccionado
        //}

        /// <summary>
        /// Traduce una clave o etiqueta al idioma actualmente seleccionado.
        /// </summary>
        /// <param name="clave">La clave o etiqueta que se desea traducir.</param>
        /// <returns>El texto traducido al idioma actualmente seleccionado.</returns>
        public string Traducir(string clave)
        {
            return BLLLanguage.Current.Traducir(clave);
        }

        /// <summary>
        /// Selecciona un idioma específico para su uso en la aplicación.
        /// </summary>
        /// <param name="idioma">El nombre del idioma que se desea seleccionar.</param>
        public void SeleccionarIdioma(string idioma)
        {
            BLLLanguage.Current.SeleccionarIdioma(idioma);
        }
        //public string Traducir(string clave)
        //{

        //}
    }
}
