using SL.Contratos.Repositories;
using SL.Domain.Entities;
using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.InfraSL.Repositories
{
    public class PermisosRepository : GenericRepository<PatenteModel>, IPermisosRepository
    {
        public PermisosRepository(AppDBContext context) : base(context)
        {

        }
    }
}
