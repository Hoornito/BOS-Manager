using SL.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Controllers
{
    public interface IPermisosController
    {
        public PatenteModel CrearPermiso(PatenteModel permiso, bool esfamilia);

        public void ActualizarPermiso(PatenteModel permiso);

        public void EliminarPermiso(PatenteModel permiso);

        public void GuardarFamilia(FamiliaModel familia);

        public void EliminarFamilia(int familia_Id);
    }
}
