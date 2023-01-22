using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos.Controllers
{
    public interface IPermisosController
    {
        public ComponenteEntity GuardarComponente(ComponenteEntity componente, bool esfamilia);
        
        public void GuardarFamilia(FamiliaEntity familia);

        public IList<PatenteEntity> GetAllPatentes();
        public IList<FamiliaEntity> GetAllFamilias();
        public void GuardarPatente(string patente, string permiso);
    }
}
