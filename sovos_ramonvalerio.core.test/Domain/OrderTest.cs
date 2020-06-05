using NUnit.Framework;
using sovos_ramonvalerio.core.Domain.Customers;
using sovos_ramonvalerio.core.Domain.Orders;
using sovos_ramonvalerio.core.Infrastructure;
using System;
using System.Linq;

namespace sovos_ramonvalerio.core.test.Domain
{
    public class OrderTest
    {
        private readonly IOrderRepository _orderRepository;

        public OrderTest()
        {
            _orderRepository = new OrderRepository();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Order_Has_Items()
        {
            //Arrange
            var customer = new Customer("Customer1", "customer1@email.com");
            var order1 = new Order(customer);
            order1.AddItem(new Item());
            order1.AddItem(new Item());
            _orderRepository.AddOrder(order1);

            //Act
            var expected = 2;
            var orders = _orderRepository.GetById(customer, order1.Id);
            var result = orders.Items.Count;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Order_Has_no_possibility_Items()
        {
            //Arrange
            var customer = new Customer("Customer1", "customer1@email.com");
            var order1 = new Order(customer);

            //Act
            try
            {
                _orderRepository.AddOrder(order1);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.Pass(ex.Message);
            }

            Assert.Fail();
        }
    }
}
