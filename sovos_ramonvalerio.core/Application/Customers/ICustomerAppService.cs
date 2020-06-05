using sovos_ramonvalerio.core.Domain.Customers;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Application.Customers
{
    public interface ICustomerAppService
    {
        IEnumerable<Customer> Return_a_list_of_customers_without_orders();
        void Add_a_new_Customer(CustomerCommand command);
    }
}