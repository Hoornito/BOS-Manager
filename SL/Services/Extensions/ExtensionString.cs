using SL.BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services.Extensions
{
    public static class ExtensionString
    {
        /// <summary>
        /// Traduce una palabra o frase al idioma actualmente seleccionado.
        /// </summary>
        /// <param name="palabra">La palabra o frase que se desea traducir.</param>
        /// <returns>La palabra o frase traducida al idioma actualmente seleccionado.</returns>
        public static string Traducir(this string palabra)
        {
            return LanguageManager.Current.Traducir(palabra);
        }

        /// <summary>
        /// Selecciona un idioma específico para su uso en la aplicación.
        /// </summary>
        /// <param name="idioma">El nombre del idioma que se desea seleccionar.</param>
        public static void SeleccionarIdioma(this string idioma)
        {
            LanguageManager.Current.SeleccionarIdioma(idioma);
        }
    }
}
