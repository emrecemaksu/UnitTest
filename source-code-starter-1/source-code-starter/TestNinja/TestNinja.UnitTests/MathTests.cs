using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class MathTests
    {
        public Fundamentals.Math math;
        [TestInitialize]
        public void init()
        {
            math = new Fundamentals.Math();
        }
        [TestMethod]
        [DataRow(1, 1, 2)]
        public void Add_WhenCalled_ReturnTheSumOfArguments(int x, int y, int exp)
        {
            var result = math.Add(x, y);
            Assert.AreEqual(exp, result);

        }
        [TestMethod]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {
            var result = math.Max(2, 1);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            var result = math.Max(1, 2);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Max_ArgumentAreEqual_ReturnTheSameArgument()
        {
            var result = math.Max(2, 2);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void GetOddNumbers_LimitIsGreaterThanZero_Not_Null()
        {
            var result = math.GetOddNumbers(4);
            //Hata burada
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = math.GetOddNumbers(4);
            //Hata burada
            int[] sayilarim = new int[2] { 1, 3};
            int[] sonuc = result.ToArray();
            CollectionAssert.AreEqual(sayilarim, sonuc);
        }
    }
}
