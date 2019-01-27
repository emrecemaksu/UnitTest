using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    /// <summary>
    /// ErrorLoggerTests için kısa açıklama
    /// </summary>
    [TestClass]
    public class ErrorLoggerTests
    {
        [TestMethod]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");
            Assert.AreEqual("a", logger.LastError);
        }
        [TestMethod]
        [DataRow("")]
        [DataRow(" ")]
        [DataRow(null)]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            //Lambda expression kullanılmadığında "void ögesinden System.action ögesine dönüştürülemiyor." hatası alınıyor.
            //Lambda expressionın Parametre kısmını () boş bırakıyoruz.
            //Boş bıraktığımız zaman Assert.ThrowsException ın istediği parametreyi kendisinin belirlemesini mi sağlıyoruz.
            //Eğer boş kalmasaydı () içine ne gelebilirdi.
            Assert.ThrowsException<ArgumentNullException>(() => logger.Log(error));
        }
    }
}
