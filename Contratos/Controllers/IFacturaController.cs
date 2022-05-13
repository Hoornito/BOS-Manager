using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Controllers
{
    public interface IFacturaController
    {
        public void GuardarCambios(FacturaEntity facturaEntity);
    }
}
