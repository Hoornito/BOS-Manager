using Domain.Models;

namespace Contratos.Services
{
    public interface IProductoService : IGenericService<ProductoModel>
    {
        /// <summary>
        /// El método "AgregarProducto" agrega un nuevo producto a alguna colección o base de datos, y toma un objeto "ProductoModel" como parámetro. Este método no devuelve ningún valor.
        /// </summary>
        /// <param name="producto"></param>
        public void AgregarProducto(ProductoModel producto);

        /// <summary>
        /// El método "ActualizarProducto" actualiza la información de un producto existente en la colección o base de datos, y toma un objeto "ProductoModel" como parámetro. Este método tampoco devuelve ningún valor.
        /// </summary>
        /// <param name="productoModel"></param>
        public void ActualizarProducto(ProductoModel productoModel);

        /// <summary>
        /// El método "EliminarProducto" elimina un producto existente de la colección o base de datos, y toma un objeto "ProductoModel" como parámetro. Este método no devuelve ningún valor.
        /// </summary>
        /// <param name="productoModel"></param>
        public void EliminarProducto(ProductoModel productoModel);
    }
}
