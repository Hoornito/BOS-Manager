using Domain.Entities;

using System.Collections.Generic;

namespace Contratos.Controllers
{
    public interface IProductoController
    {
        public void GuardarCambios(ProductoEntity productoEntity);

        public List<ProductoEntity> GetAll();

        public ProductoEntity GetProducto(string Nombre);
    }
}
