using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Controllers
{
    public interface IUsuariosController
    {
        /// <summary>
        /// Crea un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void CrearUsuario(UsuarioEntity usuario);

        /// <summary>
        /// verifica si coincide la contraseña con el usuario ingresado y devuelve true si coincide
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool Login(UsuarioEntity usuario);

        /// <summary>
        /// Cambia el idioma del usuario
        /// </summary>
        /// <param name="idioma"></param>
        /// <param name="usuario"></param>
        public void CambiarIdiomaUsuario(string idioma, string usuario);
    }
}
