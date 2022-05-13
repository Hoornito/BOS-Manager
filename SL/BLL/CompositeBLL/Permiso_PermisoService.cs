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

        public void EliminarFamilia(int familia_Id)
        {
            var listaFamilia = Get(x => x.id_permiso_padre == familia_Id);
            foreach (var familia in listaFamilia)
            {
                Eliminar(familia);
            }
        }

        public void GuardarFamilia(Permiso_PermisoModel familia)
        {
            //crear regla para no asignar una familia padre como familia hija
            
            Insertar(familia);
            _unitOfWork.Save();
        }
    }
}
