using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class FizzBuzz_Tests
    {
        [TestMethod]
        public void Return_FizzBuzz_Division3_5_True()
        {
            int a = 15;
            string donen = FizzBuzz.GetOutput(a);
            Assert.AreEqual(donen, "FizzBuzz");
        }
        [TestMethod]
        public void Return_FizzBuzz_Division3_True()
        {
            int b = 6;
            string donen = FizzBuzz.GetOutput(b);
            Assert.AreEqual(donen, "Fizz");
        }
        [TestMethod]
        public void Return_FizzBuzz_Division5_True()
        {
            int c = 10;
            string donen = FizzBuzz.GetOutput(c);
            Assert.AreEqual(donen, "Buzz");
        }
    }
}
