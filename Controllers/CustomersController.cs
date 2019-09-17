using dotnet_core_generic_api.IRepositories;
using dotnet_core_generic_api.Models;

namespace dotnet_core_generic_api.Controllers
{
    public class CustomersController : GenericControllerBase<Customer>
    {
        public CustomersController(ICustomerRepository entityRepository) : base(entityRepository)
        {
        }
    }

   
}
