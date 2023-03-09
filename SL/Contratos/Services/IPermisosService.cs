using SL.Domain.Entities;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Services
{
    public interface IPermisosService : IGenericService<PermisoModel>
    {
        /// <summary>
        /// Crea un nuevo permiso en la base de datos.
        /// </summary>
        /// <param name="permiso">El objeto PermisoModel que representa el nuevo permiso a crear.</param>
        /// <returns>El objeto PermisoModel recién creado.</returns>
        public PermisoModel CrearPermiso(PermisoModel permiso);

        /// <summary>
        /// Actualiza un permiso existente en la base de datos.
        /// </summary>
        /// <param name="permiso">El objeto PermisoModel que representa el permiso existente que se actualizará.</param>
        public void ActualizarPermiso(PermisoModel permiso);

        /// <summary>
        /// Elimina un permiso existente de la base de datos.
        /// </summary>
        /// <param name="permiso">El objeto PermisoModel que representa el permiso existente que se eliminará.</param>
        public void EliminarPermiso(PermisoModel permiso);

        /// <summary>
        /// Busca un permiso específico en una lista de permisos y devuelve un valor booleano que indica si se encontró el permiso.
        /// </summary>
        /// <param name="permisos">La lista de ComponenteEntity que representa los permisos en los cuales se buscará el permiso.</param>
        /// <param name="tipoPermiso">El tipo de permiso que se está buscando.</param>
        /// <returns>Un valor booleano que indica si se encontró el permiso.</returns>
        public bool BuscarPermiso(List<ComponenteEntity> permisos, TipoPermiso? tipoPermiso);

        /// <summary>
        /// Valida si una familia que se desea agregar a otra familia ya existe en la familia actual.
        /// </summary>
        /// <param name="familiaActual">La familia actual en la que se desea agregar la familia.</param>
        /// <param name="familiaAgregar">La familia que se desea agregar a la familia actual.</param>
        /// <returns>Un valor booleano que indica si la familia que se desea agregar ya existe en la familia actual.</returns>
        public bool ValidarPermisosRepetidos(FamiliaEntity familiaActual, FamiliaEntity familiaAgregar);
    }
}
