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

        public Customer GetByEmail(string email)
        {
            if (!_customers.ContainsKey(email))
                return null;

            return _customers[email];
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customers.Values;
        }

        public void Add(Customer customer)
        {
            if (!_customers.ContainsKey(customer.Email))
            {
                _customers.Add(customer.Email, customer);
                return;
            }

            _customers.Add(customer.Email, customer);
        }
    }
}