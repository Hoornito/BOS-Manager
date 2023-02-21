using SL.Contratos.Repositories;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.InfraSL.Repositories
{
    public class Usuario_PermisoRepository : GenericRepository<Usuario_PermisoModel>, IUsuario_PermisoRepository
    {
        public Usuario_PermisoRepository(AppDBContext context) : base(context)
        {

        }
    }
}
