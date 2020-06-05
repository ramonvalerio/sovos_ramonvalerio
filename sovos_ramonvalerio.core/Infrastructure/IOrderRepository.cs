using sovos_ramonvalerio.core.Domain.Customers;
using sovos_ramonvalerio.core.Domain.Orders;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Infrastructure
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetByCustomer(Customer customer);

        void AddOrderByCustomer(Customer customer, Order order);
    }
}