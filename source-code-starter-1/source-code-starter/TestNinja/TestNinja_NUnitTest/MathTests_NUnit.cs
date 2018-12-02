using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Tests
{
    [TestFixture]
    public class MathTests_NUnit
    {
        public TestNinja.Fundamentals.Math math;
        [SetUp]
        public void Setup()
        {
            math = new TestNinja.Fundamentals.Math();
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = math.GetOddNumbers(5);
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
        }
    }
}