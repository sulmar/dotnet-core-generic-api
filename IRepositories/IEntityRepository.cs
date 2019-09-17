using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_core_generic_api.Models;

namespace dotnet_core_generic_api.IRepositories
{
    public interface IEntityRepository<TEntity> 
    where TEntity : BaseEntity
{
    Task<IEnumerable<TEntity>> GetAsync();
    Task<TEntity> GetAsync(int id);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task RemoveAsync(int id);
}

   
}
