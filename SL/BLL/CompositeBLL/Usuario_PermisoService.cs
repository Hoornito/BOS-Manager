using SL.Contratos;
using SL.Contratos.Repositories;
using SL.Contratos.Services;
using SL.Domain.Models;
using SL.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.CompositeBLL
{
    public class Usuario_PermisoService : GenericService<Usuario_PermisoModel>, IUsuario_PermisoService
    {
        public Usuario_PermisoService(IUnitOfWork unitOfWork)
        : base(unitOfWork, unitOfWork.GetRepository<IUsuario_PermisoRepository>())
        {

        }

        public void EliminarPermisoDeUsuario(Usuario_PermisoModel usuarioPermiso)
        {
            try
            {
                _repository.Delete(usuarioPermiso);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                LoggerManager.GenerateLog(ex);
                throw;
            }
        }

        public void GuardarPermisos(Usuario_PermisoModel usuario, List<Usuario_PermisoModel> permisos)
        {
            try
            {
                var PermisosDelUsuario = Get(x => x.id_usuario == usuario.id_usuario, tracking: true).ToList();
                Eliminar(PermisosDelUsuario);

                foreach (var permiso in permisos)
                {
                    Insertar(permiso);
                }
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                LoggerManager.GenerateLog(ex);
                throw;
            }
            
        }
    }
}
