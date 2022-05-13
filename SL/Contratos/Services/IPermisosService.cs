using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Services
{
    public interface IPermisosService : IGenericService<PatenteModel>
    {
        public PatenteModel CrearPermiso(PatenteModel permiso);

        public void ActualizarPermiso(PatenteModel permiso);

        public void EliminarPermiso(PatenteModel permiso);

    }
}
