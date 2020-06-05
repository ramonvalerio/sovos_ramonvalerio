using sovos_ramonvalerio.core.Domain.Customers;
using sovos_ramonvalerio.core.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sovos_ramonvalerio.core.Infrastructure
{
    public class OrderRepository : IOrderRepository
    {
        private readonly Dictionary<string, List<Order>> _orders;

        public OrderRepository()
        {
            _orders = new Dictionary<string, List<Order>>();
        }

        public Order GetById(Customer customer, string orderId)
        {
            if (!_orders.ContainsKey(customer.Email))
                return null;

            var orders = _orders[customer.Email];
            return orders.SingleOrDefault(x => x.Id == orderId);
        }

        public IEnumerable<Order> GetByCustomer(Customer customer)
        {
            if (!_orders.ContainsKey(customer.Email))
                return new List<Order>();

            return _orders[customer.Email];
        }

        public void Add(Order order)
        {
            if (order.Items.Count < 1)
                throw new Exception("It is not possible to add an order without items.");

            if (!_orders.ContainsKey(order.CustomerEmail))
            {
                _orders.Add(order.CustomerEmail, new List<Order> { order });
                return;
            }

            var orders = _orders[order.CustomerEmail];
            orders.Add(order);
        }
    }
}