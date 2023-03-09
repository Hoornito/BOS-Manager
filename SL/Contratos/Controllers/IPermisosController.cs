using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Controllers
{
    public interface IPermisosController
    {
        /// <summary>
        /// Guarda un componente
        /// </summary>
        /// <param name="componente"></param>
        /// <param name="esfamilia"></param>
        /// <returns></returns>
        public ComponenteEntity GuardarComponente(ComponenteEntity componente, bool esfamilia);

        /// <summary>
        /// Guarda una familia
        /// </summary>
        /// <param name="familia"></param>
        public void GuardarFamilia(FamiliaEntity familia);

        /// <summary>
        /// Obtiene todas las patentes
        /// </summary>
        /// <returns></returns>
        public IList<PatenteEntity> GetAllPatentes();

        /// <summary>
        /// obtiene todas las familias
        /// </summary>
        /// <returns></returns>
        public IList<FamiliaEntity> GetAllFamilias();

        /// <summary>
        /// guarda la patente
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="permiso"></param>
        public void GuardarPatente(string patente, string permiso);

        /// <summary>
        /// Valida la existencia
        /// </summary>
        /// <param name="permisos"></param>
        /// <param name="tipoPermiso"></param>
        /// <returns></returns>
        public bool ValidarExistencia(List<ComponenteEntity> permisos, TipoPermiso? tipoPermiso);

        /// <summary>
        /// Valida las familias
        /// </summary>
        /// <param name="familiaActual"></param>
        /// <param name="familiaAgregar"></param>
        /// <returns></returns>
        public bool ValidarFamilias(FamiliaEntity familiaActual, FamiliaEntity familiaAgregar);

        /// <summary>
        /// Obtiene los usuarios
        /// </summary>
        /// <returns></returns>
        public IList<UsuarioEntity> ObtenerUsuarios();

        /// <summary>
        /// Obtiene los usuarios completos
        /// </summary>
        /// <returns></returns>
        public List<UsuarioEntity> GetAllUsuariosCompletos();

        /// <summary>
        /// Guarda los permisos
        /// </summary>
        /// <param name="u"></param>
        public void GuardarPermisos(UsuarioEntity u);

        /// <summary>
        /// obtiene el usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public UsuarioEntity GetUsuario(string nombre);

        /// <summary>
        /// obtiene el usuario completo
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public UsuarioEntity GetUsuarioCompleto(string nombre);
        

    }
}
