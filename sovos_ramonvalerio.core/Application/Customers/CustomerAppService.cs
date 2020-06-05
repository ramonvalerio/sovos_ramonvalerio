using sovos_ramonvalerio.core.Domain.Customers;
using sovos_ramonvalerio.core.Infrastructure;
using System;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Application.Customers
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> Return_a_list_of_customers_without_orders()
        {
            return _customerRepository.GetAll();
        }

        public void Add_a_new_Customer(CustomerCommand command)
        {
            var customer = new Customer(command.Name, command.Email);

            if (customer.IsValid())
            {
                _customerRepository.Add(customer);
                return;
            }

            throw new Exception("Invalid Customer.");
        }
    }
}