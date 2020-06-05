using Microsoft.AspNetCore.Mvc;
using sovos_ramonvalerio.core.Domain.Customers;
using sovos_ramonvalerio.core.Infrastructure;

namespace sovos_ramonvalerio.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_customerRepository.GetAll());
            }
            catch (System.Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string email)
        {
            try
            {
                return Ok(_customerRepository.GetByEmail(email));
            }
            catch (System.Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            try
            {
                _customerRepository.Add(customer);
                return Ok("Customer added with success.");
            }
            catch (System.Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}