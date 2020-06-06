using sovos_ramonvalerio.core.Domain.Orders;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Application.Orders
{
    public class OrderCommand
    {
        public string Description { get; set; }

        public List<Item> Items { get; set; }

        public string CustomerEmail { get; set; }
    }
}