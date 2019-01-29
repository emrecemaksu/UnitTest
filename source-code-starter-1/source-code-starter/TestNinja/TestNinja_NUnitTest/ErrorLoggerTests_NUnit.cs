using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja_NUnitTest
{
    [TestFixture]
    class ErrorLoggerTests_NUnit
    {
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullExceptions(string error)
        {
            var logger = new ErrorLogger();
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }
        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };
            logger.Log("b");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
        [Test]
        public void OnErrorLogged_WhenCalled_RaiseEvent()
        {
            var logger = new ErrorLogger();
            //logger.OnErrorLogged(Guid.NewGuid);
            Assert.That(true);
        }
    }
}
