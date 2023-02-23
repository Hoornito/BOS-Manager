using SL.Contratos;
using SL.Contratos.Repositories;
using SL.Contratos.Services;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.BLL.CompositeBLL
{
    public class Permiso_PermisoService : GenericService<Permiso_PermisoModel>, IPermiso_PermisoService
    {
        public Permiso_PermisoService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IPermiso_PermisoRepository>())
        {

        }
        
        public void GuardarFamilia(Permiso_PermisoModel permiso, List<Permiso_PermisoModel> familia)
        {
            try
            {
                var listaFamilia = _repository.Get(x => x.id_permiso_padre == permiso.id_permiso_padre).ToList();
                if (familia.Count > 0)
                    Eliminar(listaFamilia);

                //regla para no asignar una familia padre como familia hija
                if (permiso.id_permiso_padre == permiso.id_permiso_hijo)
                {
                    throw new Exception("No se puede asignar una familia padre como familia hija");
                }
                foreach (var item in familia)
                {
                    item.id_permiso_padre = permiso.id_permiso_padre;
                    Insertar(item);
                }

                _unitOfWork.Save();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
