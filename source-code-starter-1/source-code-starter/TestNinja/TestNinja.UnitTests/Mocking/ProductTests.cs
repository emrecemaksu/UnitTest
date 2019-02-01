using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            var product = new Product { ListPrice = 100 };
            var result = product.GetPrice(new Customer { IsGold = true });
            Assert.AreEqual(result, 70);
        }
        [TestMethod]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount2()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(c => c.IsGold).Returns(true);
            var product = new Product { ListPrice = 100 };
            var result = product.GetPrice(customer.Object);
            Assert.AreEqual(result, 70);
        }
    }
}
