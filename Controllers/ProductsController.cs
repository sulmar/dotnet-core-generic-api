using dotnet_core_generic_api.IRepositories;
using dotnet_core_generic_api.Models;

namespace dotnet_core_generic_api.Controllers
{
    public class ProductsController : GenericControllerBase<Product>
    {
        public ProductsController(IProductRepository entityRepository) : base(entityRepository)
        {
        }
    }

   
}
