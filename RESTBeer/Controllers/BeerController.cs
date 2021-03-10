using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RESTBeer.manager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTBeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        // GET: api/<BeerController>
        private readonly BeerManager _beerManager = new BeerManager();

        [HttpGet]
        public IEnumerable<Beer.Beer> Get()
        {
            return _beerManager.getAll();
        }

        // GET api/<BeerController>/5
        [HttpGet("{id}")]
        public Beer.Beer Get(int id)
        {
            return _beerManager.GetById(id);
        }

        // POST api/<BeerController>
        [HttpPost]
        public Beer.Beer Post([FromBody] Beer.Beer value)
        {
            return _beerManager.Add(value);
        }

        // PUT api/<BeerController>/5
        [HttpPut("{id}")]
        public Beer.Beer Put(int id, [FromBody] Beer.Beer value)
        {
            return _beerManager.Update(id, value);
        }


        // DELETE api/<BeerController>/5
        [HttpDelete("{id}")]
        public Beer.Beer Delete(int id)
        {
            return _beerManager.Delete(id);
        }
    }
}