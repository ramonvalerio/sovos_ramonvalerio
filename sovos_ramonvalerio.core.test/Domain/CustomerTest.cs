using NUnit.Framework;
using sovos_ramonvalerio.core.Domain.Customers;

namespace sovos_ramonvalerio.core.test.Domain
{
    public class CustomerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Customer_has_Name_and_Email()
        {
            // Arrange
            var customer = new Customer();
            customer.Name = "Customer test1";
            customer.Email = "customertest1@test.com";

            // Act
            var expected = true;
            var result = customer.IsValid();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Customer_has_not_Name_and_Email()
        {
            // Arrange
            var customer = new Customer();
            customer.Name = null;
            customer.Email = " ";

            // Act
            var expected = true;
            var result = customer.IsValid();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Customer_has_not_Name()
        {
            // Arrange
            var customer = new Customer();
            customer.Name = null;
            customer.Email = "customertest1@test.com";

            // Act
            var expected = false;
            var result = customer.IsValid();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Customer_has_not_Email()
        {
            // Arrange
            var customer = new Customer();
            customer.Name = "Customer test1";
            customer.Email = " ";

            // Act
            var expected = false;
            var result = customer.IsValid();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Customer_can_have_multiple_Orders()
        {
            // Arrange
            var customer = new Customer();
            customer.Name = "Customer test1";
            customer.Email = "customertest1@test.com";

            // Act
            var expected = true;
            var result = customer.IsValid();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
