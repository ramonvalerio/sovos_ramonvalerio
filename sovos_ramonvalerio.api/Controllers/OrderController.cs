using Microsoft.AspNetCore.Mvc;
using sovos_ramonvalerio.core.Application.Orders;

namespace sovos_ramonvalerio.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderAppService _orderAppService;

        public OrderController(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        [HttpGet("{email}")]
        public IActionResult Get(string email)
        {
            try
            {
                return Ok(_orderAppService.Return_a_customer_and_his_orders(email));
            }
            catch (System.Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderCommand command)
        {
            try
            {
                _orderAppService.Add_a_new_Order_and_Order_Item_for_an_existing_Customer(command);
                return Ok("Customer added with success.");
            }
            catch (System.Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}