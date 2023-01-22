using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Services
{
    public interface IPermiso_PermisoService : IGenericService<Permiso_PermisoModel>
    {
        public void GuardarFamilia(Permiso_PermisoModel familia, List<Permiso_PermisoModel> hijos);
    }
}
