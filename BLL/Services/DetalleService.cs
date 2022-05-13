using Contratos.Repositories;
using Contratos.Services;

using Domain.Models;

using SL.Services;

using System;
using System.Linq;

namespace BLL.Services
{
    public class DetalleService : GenericService<DetalleModel>, IDetalleService
    {
        public DetalleService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IDetalleRepository>())
        {

        }

        public void AgergarADetalle(DetalleModel detalleModel)
        {
            try
            {
                var _productoRepo = _unitOfWork.GetRepository<IProductoRepository>();
                var producto = _productoRepo.GetById(detalleModel.Id_Producto);
                //producto.Get(x => x.Id_Producto == detalleModel.Id_Producto).FirstOrDefault();
                if (producto.Cantidad < detalleModel.Cantidad)
                {
                    throw new Exception($"No hay stock suficiente del producto: {producto.Nombre}.");
                }
                else
                {
                    Insertar(detalleModel);
                    producto.Cantidad -= detalleModel.Cantidad;
                    _productoRepo.Update(producto);
                    _unitOfWork.Save();
                    LoggerManager.Info($"Se agregó el detalle al pedido {detalleModel.Id_Pedido}");
                    if (producto.Cantidad < 25)
                    {
                        throw new Exception($"Stock reducido del producto: {producto.Nombre}. \nQuedan: {producto.Cantidad} unidades.");
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ActualizarDetalle(DetalleModel detalleModel)
        {
            Actualizar(detalleModel);

            _unitOfWork.Save();
        }

        public void EliminarDeDetalle(DetalleModel detalleModel)
        {

            try
            {
                var _productoRepo = _unitOfWork.GetRepository<IProductoRepository>();
                var producto = _productoRepo.GetById(detalleModel.Id_Producto);
                //producto.Get(x => x.Id_Producto == detalleModel.Id_Producto).FirstOrDefault();

                Eliminar(detalleModel);
                producto.Cantidad += detalleModel.Cantidad;
                _productoRepo.Update(producto);

                _unitOfWork.Save();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
