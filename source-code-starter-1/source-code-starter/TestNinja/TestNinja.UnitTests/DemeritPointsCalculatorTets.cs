using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class DemeritPointsCalculatorTets
    {
        [TestMethod]
        public void Speed_Less_0_And_Big_MaxSpeed_Except()
        {
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(400));
        }
        [TestMethod]
        public void Speed_Less_SpeedLimit_return_0()
        {
            DemeritPointsCalculator calculator1 = new DemeritPointsCalculator();
            var result = calculator1.CalculateDemeritPoints(50);
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        [DataRow(70, 1)]
        [DataRow(64, 0)]
        [DataRow(75, 2)]
        [DataRow(0, 0)]
        public void Speed_Big_SpeedLimit_return_demerits(int speed, int expectedResult)
        {
            DemeritPointsCalculator calculator2 = new DemeritPointsCalculator();
            var result1 = calculator2.CalculateDemeritPoints(speed);
            Assert.AreEqual(result1, expectedResult);
        }
    }
}
