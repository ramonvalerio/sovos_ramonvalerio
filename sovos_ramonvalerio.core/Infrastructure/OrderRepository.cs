using sovos_ramonvalerio.core.Domain.Customers;
using sovos_ramonvalerio.core.Domain.Orders;
using System;
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

        public IEnumerable<Order> GetByCustomer(Customer customer)
        {
            if (!_orders.ContainsKey(customer.Id))
                return new List<Order>();

            return _orders[customer.Id];
        }

        public void AddOrderByCustomer(Customer customer, Order order)
        {
            if (!_orders.ContainsKey(customer.Id))
            {
                _orders.Add(customer.Id, new List<Order> { order });
                return;
            }

            var orders = _orders[customer.Id];
            orders.Add(order);
        }
    }
}