using System.Numerics;
using CodeWars.Kata._4kyu;
using NUnit.Framework;

namespace CodeWarsTests.Kata._4kyu
{
    public class TwiceLinearCaseTests : BaseTest
    {
        public override void RunTests()
        {
            TwiceLinearCase.diagonal(20, 3);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(new BigInteger(5985), TwiceLinearCase.diagonal(20, 3));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(new BigInteger(20349), TwiceLinearCase.diagonal(20, 4));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(new BigInteger(54264), TwiceLinearCase.diagonal(20, 5));
        }
    }
}