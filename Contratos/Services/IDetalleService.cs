using Domain.Models;

namespace Contratos.Services
{
    public interface IDetalleService : IGenericService<DetalleModel>
    {
        public void AgergarADetalle(DetalleModel detalleModel);

        public void ActualizarDetalle(DetalleModel detalleModel);

        public void EliminarDeDetalle(DetalleModel detalleModel);
    }
}
