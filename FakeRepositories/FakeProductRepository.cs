using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_core_generic_api.IRepositories;
using dotnet_core_generic_api.Models;

namespace dotnet_core_generic_api.FakeRepositories
{
    public class FakeProductRepository : IProductRepository
    {
        private readonly ICollection<Product> products;

        public FakeProductRepository()
        {
            this.products = new List<Product>
            {
                new Product { Name = "Product 1" },
                new Product { Name = "Product 2" },
                new Product { Name = "Product 3" },
            };
        }

        public Task AddAsync(Product entity)
        {
            return Task.Run(()=>products.Add(entity));
        }

        public Task<IEnumerable<Product>> GetAsync()
        {
            return Task.FromResult<IEnumerable<Product>>(products);
        }

        public Task<Product> GetAsync(int id)
        {
            return Task.FromResult<Product>(products.SingleOrDefault(p=>p.Id == id));
        }

        public async Task RemoveAsync(int id)
        {
            Product product = await GetAsync(id);

            products.Remove(product);
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }

   
}
