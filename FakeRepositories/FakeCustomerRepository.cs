using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_core_generic_api.IRepositories;
using dotnet_core_generic_api.Models;

namespace dotnet_core_generic_api.FakeRepositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        private readonly ICollection<Customer> customers;

        public FakeCustomerRepository()
        {
            this.customers = new List<Customer>
            {
                new Customer { FirstName = "Customer 1" },
                new Customer { FirstName = "Customer 2" },
                new Customer { FirstName = "Customer 3" },
            };
        }

        public Task AddAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAsync()
        {
            return Task.FromResult<IEnumerable<Customer>>(customers);
        }

        public Task<Customer> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

   
}
