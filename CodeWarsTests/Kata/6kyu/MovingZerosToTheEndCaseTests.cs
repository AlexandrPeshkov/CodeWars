using CodeWars.Kata._5kyu;
using NUnit.Framework;

namespace CodeWarsTests.Kata._6kyu
{
    public class MovingZerosToTheEndCaseTests : BaseTest
    {
        [Test]
        public override void RunTests()
        {
            Assert.AreEqual(1, MovingZerosToTheEndCase.CountOneBits(4));
            Assert.AreEqual(0, MovingZerosToTheEndCase.CountOneBits(0));
            Assert.AreEqual(3, MovingZerosToTheEndCase.CountOneBits(7));
            Assert.AreEqual(2, MovingZerosToTheEndCase.CountOneBits(9));
            Assert.AreEqual(2, MovingZerosToTheEndCase.CountOneBits(10));
        }
    }
}