using System.Linq;
using System.Threading.Tasks;
using dotnet_core_generic_api.IRepositories;
using dotnet_core_generic_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet_core_generic_api.Controllers
{

    [ApiController]
[Route("api/[controller]")]
public abstract class GenericControllerBase<TEntity> : ControllerBase
        where TEntity : BaseEntity
    {
        protected readonly IEntityRepository<TEntity> entityRepository;

        public GenericControllerBase(IEntityRepository<TEntity> entityRepository)
        {
            this.entityRepository = entityRepository;
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            var entities = await entityRepository.GetAsync();

            return Ok(entities);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(int id)
        {
            TEntity entity = await entityRepository.GetAsync(id);
            
            if (entity == null)
               return NotFound();
        
            return Ok();
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(int id, TEntity entity)
        {
            await entityRepository.UpdateAsync(entity);

            return Ok();
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post(TEntity entity)
        {
            await entityRepository.AddAsync(entity);

            return CreatedAtRoute("DefaultApi", new { id = entity.Id }, entity);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            await entityRepository.RemoveAsync(id);

            return Ok();
        }

    }

   
}
