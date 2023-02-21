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
        public ComponenteEntity GuardarComponente(ComponenteEntity componente, bool esfamilia);
        
        public void GuardarFamilia(FamiliaEntity familia);

        public IList<PatenteEntity> GetAllPatentes();
        public IList<FamiliaEntity> GetAllFamilias();
        public void GuardarPatente(string patente, string permiso);
        public bool ValidarExistencia(List<ComponenteEntity> permisos, TipoPermiso? tipoPermiso);
        public bool ValidarFamilias(FamiliaEntity familiaActual, FamiliaEntity familiaAgregar);
        public IList<UsuarioEntity> ObtenerUsuarios();
        public List<UsuarioEntity> GetAllUsuariosCompletos();
        public void GuardarPermisos(UsuarioEntity u);
        public UsuarioEntity GetUsuario(string nombre);
        public UsuarioEntity GetUsuarioCompleto(string nombre);
        

    }
}
