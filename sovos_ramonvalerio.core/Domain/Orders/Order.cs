using sovos_ramonvalerio.core.Domain.Customers;
using System;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Domain.Orders
{
    public class Order
    {
        public string Id { get; private set; }

        public string Description { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public List<Item> Items { get; private set; }

        public string CustomerId { get; private set; }

        public Order(Customer customer, string Description = null)
        {
            Id = Guid.NewGuid().ToString("D");
            CustomerId = customer.Id;
            CreatedDate = DateTime.Now;
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public bool IsValid()
        {
            if (Items.Count >= 1)
                return true;

            return false;
        }
    }
}