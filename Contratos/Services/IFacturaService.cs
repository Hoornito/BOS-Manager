using Domain.Models;

namespace Contratos.Services
{
    public interface IFacturaService : IGenericService<FacturaModel>
    {
        public void CrearFactura(FacturaModel facturaModel);
    }
}
