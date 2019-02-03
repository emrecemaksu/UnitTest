using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestClass]
    public class InstallerHelperTests
    {
        [TestMethod]
        public void InstallerHelper_DownloadInstalle_Return_False()
        {
            var _helper = new Mock<IHelper>();
            var _insHelper = new InstallerHelper(_helper.Object);
            _helper.Setup(tr => tr.DownloadFile("http://example.com/customer/installer",null)).Throws<WebException>();
            var result = _insHelper.DownloadInstaller("customer", "installer");
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void InstallerHelper_DownloadInstalle_Return_True()
        {
            var _helper1 = new Mock<IHelper>();
            var _insHelper1 = new InstallerHelper(_helper1.Object);
            //_helper1.Setup(tr1 => tr1.DownloadFile(It.IsAny<string>(), It.IsAny<string>())).Throws<WebException>();
            //result,false => Testi Geçiyor.
            var result = _insHelper1.DownloadInstaller("customer", "installer");
            Assert.AreEqual(result, true);
            //Bu şekilde de test geçiyor.
        }
    }
}
