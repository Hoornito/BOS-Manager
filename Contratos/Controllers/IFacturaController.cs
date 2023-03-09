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
        /// <summary>
        /// guardar cambios
        /// </summary>
        /// <param name="facturaEntity"></param>
        public void GuardarCambios(FacturaEntity facturaEntity);
    }
}
