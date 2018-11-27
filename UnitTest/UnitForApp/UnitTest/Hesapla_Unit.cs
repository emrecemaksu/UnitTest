
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitForApp;

namespace UnitTest
{
    [TestClass]
    public class Hesapla_Unit
    {
        Hesapla hesapla_obj;
        [TestInitialize]
        public void init()
        {
            hesapla_obj = new Hesapla();
        }
        [Owner("Emre Cem Aksu")] 
        [Priority(0)]
        [TestCategory("Hesapla")]
        [TestMethod]
        public void MainPage_Hesapla_Negatif_False()
        {
            decimal boy = -215;
            decimal kilo = -20;
            decimal result = hesapla_obj.hesapla(boy, kilo);
            if(result <= 0)
            {
                Assert.Fail("Vucut Kitle Endeksi 0 ve 0 dan kucuk cıkamaz.");
            }
            else
            {
                Assert.IsTrue(true);
            }
        }
        [Owner("Emre Cem Aksu")]
        [Priority(0)]
        [TestCategory("Hesapla")]
        [TestMethod]
        public void MainPage_Hesapla_Equal()
        {
            decimal boy = 1;
            decimal kilo = 1;
            decimal expected = 10000;
            Assert.AreEqual(expected, hesapla_obj.hesapla(boy, kilo));
        }
        [TestCleanup]
        public void cleanup()
        {
            hesapla_obj = null;
        }
    }
}
