using SL.Contratos.Repositories;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.InfraSL.Repositories
{
    public class UsuariosRepository : GenericRepository<UsuarioModel>, IUsuariosRepository
    {
        public UsuariosRepository(AppDBContext context) : base(context)
        {

        }
    }
}
