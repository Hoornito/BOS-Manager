using Contratos.Repositories;
using Contratos.Services;

using Domain.Models;

using SL.Services;
using SL.Tools;

using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class PedidoService : GenericService<PedidoModel>, IPedidoService
    {
        public PedidoService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IPedidoRepository>())
        {

        }

        public void ActualizarPedido(PedidoModel pedidoModel)
        {
            try
            {
                var _detalleService = _unitOfWork.GetRepository<IDetalleRepository>();

                List<DetalleModel> detalle = _detalleService.Get(x => x.Id_Pedido == pedidoModel.Id_Pedido, includeProperties: "Producto").ToList();
                pedidoModel.Total = 0;
                foreach (var item in detalle)
                {
                    pedidoModel.Total += (item.Cantidad * item.Producto.PrecioUnidad);
                }

                Actualizar(pedidoModel);
                _unitOfWork.Save();

                pedidoModel = Get(x => x.Id_Pedido == pedidoModel.Id_Pedido, includeProperties: "Cliente").FirstOrDefault();
                //if (pedidoModel.Estado == "Finalizado")
                //{
                //    MessageService messageService = new MessageService();
                //    if (pedidoModel.Retiro == "Repartir")
                //        messageService.SendMessage(pedidoModel.TelefonoContacto, pedidoModel);
                //    else
                //        messageService.SendMessageRetiro(pedidoModel.TelefonoContacto, pedidoModel);
                //}
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void CrearPedido(PedidoModel pedidoModel)
        {
            try
            {
                pedidoModel.Estado = "Nuevo";
                pedidoModel.FechaHora = DateTime.Now;
                Insertar(pedidoModel);
                                
                //_unitOfWork.Save();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<PedidoModel> ObtenerPedido()
        {
            throw new NotImplementedException();
        }
    }
}
