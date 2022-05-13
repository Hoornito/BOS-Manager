using Domain.Models;

using System.Collections.Generic;

namespace Contratos.Services
{
    public interface IPedidoService : IGenericService<PedidoModel>
    {
        public List<PedidoModel> ObtenerPedido();

        public void CrearPedido(PedidoModel pedidoModel);

        public void ActualizarPedido(PedidoModel pedidoModel);
    }
}
