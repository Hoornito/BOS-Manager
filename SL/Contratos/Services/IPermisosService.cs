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
        public PermisoModel CrearPermiso(PermisoModel permiso);

        public void ActualizarPermiso(PermisoModel permiso);

        public void EliminarPermiso(PermisoModel permiso);
        
        public bool BuscarPermiso(List<ComponenteEntity> permisos, TipoPermiso? tipoPermiso);
        public bool ValidarPermisosRepetidos(FamiliaEntity familiaActual, FamiliaEntity familiaAgregar);
    }
}
