using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace sovos_ramonvalerio.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Order 1", "Order 2" };
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Order 1";
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
    }
}