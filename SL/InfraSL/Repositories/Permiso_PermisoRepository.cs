using SL.Contratos.Repositories;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.InfraSL.Repositories
{
    public class Permiso_PermisoRepository : GenericRepository<Permiso_PermisoModel>, IPermiso_PermisoRepository
    {
        public Permiso_PermisoRepository(AppDBContext context) : base(context)
        {

        }
    }
}
