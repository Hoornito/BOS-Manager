using Contratos.Repositories;
using Contratos.Services;

using Domain.Models;
using SL.Services;


using System;
using System.Linq;

namespace BLL.Services
{
    public class ProductoService : GenericService<ProductoModel>, IProductoService
    {
        public ProductoService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IProductoRepository>())
        {

        }

        public void AgregarProducto(ProductoModel productoModel)
        {
            try
            {
                var helper = Get(x => x.Nombre == productoModel.Nombre).FirstOrDefault();
                if (helper == null)
                {
                    productoModel.Id_Producto = Guid.NewGuid();
                    Insertar(productoModel);

                    _unitOfWork.Save();
                                                            
                }
                else
                {
                    throw new Exception("El producto ya existe.");
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void ActualizarProducto(ProductoModel productoModel)
        {
            Actualizar(productoModel);

            _unitOfWork.Save();
        }

        public void EliminarProducto(ProductoModel productoModel)
        {
            Eliminar(productoModel);

            _unitOfWork.Save();

        }

    }
}
