using NUnit.Framework;
using sovos_ramonvalerio.core.Domain.Customers;
using sovos_ramonvalerio.core.Domain.Orders;
using sovos_ramonvalerio.core.Infrastructure;
using System.Linq;

namespace sovos_ramonvalerio.core.test.Domain
{
    public class CustomerTest
    {
        private readonly IOrderRepository _orderRepository;

        public CustomerTest()
        {
            _orderRepository = new OrderRepository();
        }

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Customer_has_Name_and_Email()
        {
            // Arrange
            var customer = new Customer("Customer test1", "customertest1@test.com");            

            // Act
            var expected = true;
            var result = customer.IsValid();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Customer_has_no_Name_and_Email()
        {
            // Arrange
            var customer = new Customer(null, " ");

            // Act
            var expected = false;
            var result = customer.IsValid();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Customer_has_no_Name()
        {
            // Arrange
            var customer = new Customer(null, "customertest1@test.com");

            // Act
            var expected = false;
            var result = customer.IsValid();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Customer_has_no_Email()
        {
            // Arrange
            var customer = new Customer("Customer test1", " ");

            // Act
            var expected = false;
            var result = customer.IsValid();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Customer_has_multiple_Orders()
        {
            // Arrange
            var customer = new Customer("Customer test1", "customertest1@test.com");

            // Creating a Order1 and Adding some Items
            var order1 = new Order(customer);
            order1.AddItem(new Item());
            order1.AddItem(new Item());

            // Creating Order2 and Adding an Item
            var order2 = new Order(customer);
            order2.AddItem(new Item());

            // Registering Orders 
            _orderRepository.Add(order1);
            _orderRepository.Add(order2);

            // Act
            var expected = 2;
            var result = _orderRepository.GetByCustomer(customer).Count();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Customer_has_no_Orders()
        {
            // Arrange
            var customer = new Customer("Customer test1", "customertest1@test.com");

            // Act
            var expected = 0;
            var result = _orderRepository.GetByCustomer(customer).Count();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
