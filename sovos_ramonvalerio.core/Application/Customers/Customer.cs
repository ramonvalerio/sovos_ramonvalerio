using System;

namespace sovos_ramonvalerio.core.Application.Customers
{
    public class Customer
    {
        public string Id { get; private set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Customer()
        {
            Id = Guid.NewGuid().ToString("D");
        }
    }
}