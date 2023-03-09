using Domain.Models;

using System.Collections.Generic;

namespace Contratos.Services
{
    public interface IPedidoService : IGenericService<PedidoModel>
    {
        /// <summary>
        /// Obtiene el pedido
        /// </summary>
        /// <returns></returns>
        public List<PedidoModel> ObtenerPedido();

        /// <summary>
        /// Crea un pedido
        /// </summary>
        /// <param name="pedidoModel"></param>
        public void CrearPedido(PedidoModel pedidoModel);

        /// <summary>
        /// Actualiza el pedido
        /// </summary>
        /// <param name="pedidoModel"></param>
        public void ActualizarPedido(PedidoModel pedidoModel);
    }
}
