using System;
using System.Collections.Generic;

namespace sovos_ramonvalerio.core.Domain.Orders
{
    public class Order
    {
        public string Id { get; private set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Item> Items { get; private set; }

        public int CustomerId { get; set; }

        public Order()
        {
            Id = Guid.NewGuid().ToString("D");
            Items = new List<Item>();
        }
    }
}