using CodeWars.Kata;
using NUnit.Framework;

namespace CodeWarsTests.Kata
{
    public class EvenOrOddTests : BaseTest
    {
        public override void RunTests()
        {
            Assert.AreEqual("Even", EvenOrOddCase.EvenOrOdd(2));
            Assert.AreEqual("Odd", EvenOrOddCase.EvenOrOdd(1));
            Assert.AreEqual("Even", EvenOrOddCase.EvenOrOdd(0));
            Assert.AreEqual("Odd", EvenOrOddCase.EvenOrOdd(7));
            Assert.AreEqual("Odd", EvenOrOddCase.EvenOrOdd(-1));
        }
    }
}