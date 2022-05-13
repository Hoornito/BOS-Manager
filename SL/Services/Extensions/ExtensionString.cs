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
        public static string Traducir(this string palabra)
        {
            return LanguageManager.Current.Traducir(palabra);
        }
    }
}
