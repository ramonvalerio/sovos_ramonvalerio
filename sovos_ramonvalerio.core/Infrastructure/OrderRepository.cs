using sovos_ramonvalerio.core.Domain.Orders;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Infrastructure
{
    public class OrderRepository : IOrderRepository
    {
        private readonly Dictionary<string, List<Order>> _orders;

        public OrderRepository()
        {
            _orders = new Dictionary<string, List<Order>>();
        }
    }
}