using Domain.Entities;

using System.Collections.Generic;

namespace Contratos.Controllers
{
    public interface IDetalleController
    {
        /// <summary>
        /// Metodo para obtener el detalle de un pedido
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        List<DetalleEntity> ObtenerDetalle(PedidoEntity pedido);
        /// <summary>
        /// Metodo para guardar Cambios
        /// </summary>
        /// <param name="detalle"></param>
        public void GuardarCambios(DetalleEntity detalle);
        /// <summary>
        /// Metodo para obtener el Id del detalle
        /// </summary>
        /// <param name="pedidoId"></param>
        /// <param name="nombreProducto"></param>
        /// <returns></returns>
        public DetalleEntity ObtenerDetalleId(int pedidoId, string nombreProducto);
    }
}
