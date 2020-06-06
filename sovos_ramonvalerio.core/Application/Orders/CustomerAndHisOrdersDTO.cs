using sovos_ramonvalerio.core.Domain.Customers;
using sovos_ramonvalerio.core.Domain.Orders;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Application.Orders
{
    public class CustomerAndHisOrdersDTO
    {
        public Customer Customer { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}