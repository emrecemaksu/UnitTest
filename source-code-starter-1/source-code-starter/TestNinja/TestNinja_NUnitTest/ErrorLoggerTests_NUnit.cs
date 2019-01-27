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
            //Anlamadım... id = 000000 olarak geçerken. 28 satırdan sonra nasıl geriye dönük farklı değer aldı.
            //id olay gerçekleşse bile local bir değişken değil mi?
            //Delegate Event Olayı
            logger.ErrorLogged += (sender, args) => { id = args; };
            logger.Log("b");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
