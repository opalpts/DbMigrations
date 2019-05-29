using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbMigrations.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbMigrations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private MainDBcontext _mainDbContext;

        public ValuesController(MainDBcontext mainDbContext)
        {
            _mainDbContext = mainDbContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _mainDbContext.Products.ToList();
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Product> Post(Product product)
        {
            _mainDbContext.Products.Add(product);
            _mainDbContext.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string Id, Product item)
        {

            if (Id != item.Id)
            {
                return BadRequest();
            }

            _mainDbContext.Entry(item).State = EntityState.Modified;
            await _mainDbContext.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
