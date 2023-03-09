using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Services
{
    public interface IUsuario_PermisoService : IGenericService<Usuario_PermisoModel>
    {
        /// <summary>
        /// Guarda los permisos para un usuario dado en la base de datos.
        /// </summary>
        /// <param name="usuario">El objeto Usuario_PermisoModel que contiene el usuario para el cual se guardarán los permisos.</param>
        /// <param name="permisos">La lista de objetos Usuario_PermisoModel que representan los permisos que se guardarán para el usuario.</param>
        void GuardarPermisos(Usuario_PermisoModel usuario, List<Usuario_PermisoModel> permisos);

        /// <summary>
        /// Elimina un permiso específico de un usuario dado en la base de datos.
        /// </summary>
        /// <param name="usuario">El objeto Usuario_PermisoModel que contiene el usuario del cual se eliminará el permiso.</param>
        void EliminarPermisoDeUsuario(Usuario_PermisoModel usuario);
    }
}
