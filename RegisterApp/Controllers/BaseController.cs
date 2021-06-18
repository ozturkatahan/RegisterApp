using Microsoft.AspNetCore.Mvc;
using RegisterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Controllers
{
    public abstract class BaseController<TEntity, TRepository> : Controller
         where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;
        public BaseController(TRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var register = await repository.Get(id);
            if (register == null)
            {
                return NotFound();
            }
            return register;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity register)
        {
            if (id != register.Id)
            {
                return BadRequest();
            }
            await repository.Update(register);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity register)
        {
            await repository.Add(register);
            return CreatedAtAction("Get", new { id = register.Id }, register);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var register = await repository.Delete(id);
            if (register == null)
            {
                return NotFound();
            }
            return register;
        }

    }
}
