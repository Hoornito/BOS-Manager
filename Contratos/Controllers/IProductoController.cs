using Domain.Entities;

using System.Collections.Generic;

namespace Contratos.Controllers
{
    public interface IProductoController
    {
        /// <summary>
        /// guarda los cambios realizados
        /// </summary>
        /// <param name="productoEntity"></param>
        public void GuardarCambios(ProductoEntity productoEntity);

        /// <summary>
        /// obtiene todo
        /// </summary>
        /// <returns></returns>
        public List<ProductoEntity> GetAll();

        /// <summary>
        /// obtiene un producto por nombre
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns></returns>
        public ProductoEntity GetProducto(string Nombre);
    }
}
