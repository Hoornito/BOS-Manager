using Domain.Models;

namespace Contratos.Services
{
    public interface IProductoService : IGenericService<ProductoModel>
    {
        public void AgregarProducto(ProductoModel producto);

        public void ActualizarProducto(ProductoModel productoModel);

        public void EliminarProducto(ProductoModel productoModel);
    }
}
