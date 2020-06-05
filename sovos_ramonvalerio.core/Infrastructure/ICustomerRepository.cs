using sovos_ramonvalerio.core.Domain.Customers;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Infrastructure
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        void Add(Customer customer);
        Customer GetByEmail(string email);
    }
}