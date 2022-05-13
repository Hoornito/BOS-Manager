using Domain.Entities;

using System.Collections.Generic;

namespace Contratos.Controllers
{
    public interface IDetalleController
    {
        List<DetalleEntity> ObtenerDetalle(PedidoEntity pedido);

        public void GuardarCambios(DetalleEntity detalle);
        public DetalleEntity ObtenerDetalleId(int pedidoId, string nombreProducto);
    }
}
