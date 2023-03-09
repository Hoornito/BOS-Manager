using Domain.Models;

namespace Contratos.Services
{
    public interface IDetalleService : IGenericService<DetalleModel>
    {
        /// <summary>
        /// Agrega un detalle
        /// </summary>
        /// <param name="detalleModel"></param>
        public void AgergarADetalle(DetalleModel detalleModel);

        /// <summary>
        /// Actualiza el detalle
        /// </summary>
        /// <param name="detalleModel"></param>
        public void ActualizarDetalle(DetalleModel detalleModel);

        /// <summary>
        /// Elimina el detalle
        /// </summary>
        /// <param name="detalleModel"></param>
        public void EliminarDeDetalle(DetalleModel detalleModel);
    }
}
