using sovos_ramonvalerio.core.Domain.Orders;
using System;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Domain.Customers
{
    public class Customer
    {
        public string Id { get; private set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public List<Order> Orders { get; set; }

        public Customer()
        {
            Id = Guid.NewGuid().ToString("D");
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return false;

            if (string.IsNullOrWhiteSpace(Email))
                return false;

            return true;
        }
    }
}