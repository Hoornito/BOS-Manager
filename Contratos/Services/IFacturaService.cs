using Domain.Models;

namespace Contratos.Services
{
    public interface IFacturaService : IGenericService<FacturaModel>
    {
        /// <summary>
        /// Crea una factura
        /// </summary>
        /// <param name="facturaModel"></param>
        public void CrearFactura(FacturaModel facturaModel);
        /// <summary>
        /// Obtiene ultima factura
        /// </summary>
        /// <returns></returns>
        public FacturaModel ObtenerUltimaFactura();
    }
}
