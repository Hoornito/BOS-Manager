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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        public ProductoService(IUnitOfWork unitOfWork)
            : base(unitOfWork, unitOfWork.GetRepository<IProductoRepository>())
        {

        }

        /// <summary>
        /// Agrega un producto
        /// </summary>
        /// <param name="productoModel"></param>
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

        /// <summary>
        /// Actualiza el producto
        /// </summary>
        /// <param name="productoModel"></param>
        public void ActualizarProducto(ProductoModel productoModel)
        {
            Actualizar(productoModel);

            _unitOfWork.Save();
        }

        /// <summary>
        /// Elimina el producto
        /// </summary>
        /// <param name="productoModel"></param>
        public void EliminarProducto(ProductoModel productoModel)
        {
            Eliminar(productoModel);

            _unitOfWork.Save();

        }

    }
}
