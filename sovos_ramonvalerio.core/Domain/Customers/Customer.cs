using sovos_ramonvalerio.core.Domain.Orders;
using System;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Domain.Customers
{
    public class Customer
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public List<Order> Orders { get; private set; }

        public Customer(string name, string email)
        {
            Id = Guid.NewGuid().ToString("D");
            Name = name;
            Email = email;
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