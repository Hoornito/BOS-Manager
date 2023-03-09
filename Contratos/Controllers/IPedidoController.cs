using Domain.Entities;

using System.Collections.Generic;

namespace Contratos.Controllers
{
    public interface IPedidoController
    {
        /// <summary>
        /// obtiene el ultimo pedido
        /// </summary>
        /// <returns></returns>
        public PedidoEntity ObtenerUltimoPedido();

        /// <summary>
        /// guarda los cambios realizados
        /// </summary>
        /// <param name="pedidoEntity"></param>
        public void GuardarCambios(PedidoEntity pedidoEntity);

        /// <summary>
        /// obtiene los pedidos
        /// </summary>
        /// <returns></returns>
        public List<PedidoEntity> ObtenerPedidos();
        /// <summary>
        /// obtiene los pedidos a ser facturados
        /// </summary>
        /// <returns></returns>
        public List<PedidoEntity> ObtenerPedidosParaFacturar();

        /// <summary>
        /// obtiene un pedido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PedidoEntity ObtenerPedido(int id);
    }
}
