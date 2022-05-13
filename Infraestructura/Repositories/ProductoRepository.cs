using Contratos.Repositories;

using Domain.Models;

namespace Infraestructura.Repositories
{
    public class ProductoRepository : GenericRepository<ProductoModel>, IProductoRepository
    {
        public ProductoRepository(AppDBContext context) : base(context)
        {

        }
    }

}
