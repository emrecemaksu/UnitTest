using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestClass]
    public class EmployeeControllerTests
    {
        [TestMethod]
        public void DeleteEmployee_WhenCalled_DeleteTheEmployeeDb()
        {
            var storage = new Mock<IEmployeeStorage>();
            var controller = new EmployeeController(storage.Object);
            controller.DeleteEmployee(1);
            storage.Verify(sd => sd.DeleteEmployee(1));
        }
    }
}
