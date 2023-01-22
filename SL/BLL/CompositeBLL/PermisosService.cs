using SL.Contratos;
using SL.Contratos.Repositories;
using SL.Contratos.Services;
using SL.Domain.Entities;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.CompositeBLL
{
    public class PermisosService : GenericService<PermisoModel>, IPermisosService
    {
        public PermisosService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IPermisosRepository>())
        {

        }

        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(TipoPermiso));
        }
        
        public void ActualizarPermiso(PermisoModel permiso)
        {
            throw new NotImplementedException();
        }

        public PermisoModel CrearPermiso(PermisoModel permiso)
        {
            try
            {
                Insertar(permiso);

                _unitOfWork.Save();

                return permiso;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarPermiso(PermisoModel permiso)
        {
            Eliminar(permiso);
        }
    }
}
