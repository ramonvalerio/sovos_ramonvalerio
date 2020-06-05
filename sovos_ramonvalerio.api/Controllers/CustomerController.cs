using Microsoft.AspNetCore.Mvc;
using sovos_ramonvalerio.core.Application.Customers;
using sovos_ramonvalerio.core.Domain.Customers;

namespace sovos_ramonvalerio.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_customerAppService.Return_a_list_of_customers_without_orders());
            }
            catch (System.Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] CustomerCommand command)
        {
            try
            {
                var customer = new Customer(command.Name, command.Email);
                return Ok("Customer added with success.");
            }
            catch (System.Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}