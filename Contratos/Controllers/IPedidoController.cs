using Domain.Entities;

using System.Collections.Generic;

namespace Contratos.Controllers
{
    public interface IPedidoController
    {
        public PedidoEntity ObtenerUltimoPedido();

        public void GuardarCambios(PedidoEntity pedidoEntity);

        public List<PedidoEntity> ObtenerPedidos();

        public List<PedidoEntity> ObtenerPedidosParaFacturar();

        public PedidoEntity ObtenerPedido(int id);
    }
}
