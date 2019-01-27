using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class CustomerControllerTests
    {
        [TestMethod]
        public void GetCustomer_Id_IsZero_Return_NotFound()
        {
            var customer1 = new CustomerController();
            var result = customer1.GetCustomer(0);
            Assert.IsInstanceOfType(result, typeof(NotFound));
        }
        [TestMethod]
        public void GetCustomer_Id_IsNotZero_Return_Ok()
        {
            var customer = new CustomerController();
            var result = customer.GetCustomer(4);
            Assert.IsInstanceOfType(result, typeof(Ok));
        }
    }
}
