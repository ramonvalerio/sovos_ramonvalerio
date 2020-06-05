using sovos_ramonvalerio.core.Domain.Customers;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Dictionary<string, Customer> _customers; 

        public CustomerRepository()
        {
            _customers = new Dictionary<string, Customer>();
        }
    }
}