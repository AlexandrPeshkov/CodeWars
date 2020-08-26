using CodeWars.Kata.Juniour;
using NUnit.Framework;

namespace CodeWarsTests.Kata.Juniour
{
    internal class ExesAndOhsTests : BaseTest
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, ExesAndOhs.XO("xo"));
            Assert.AreEqual(true, ExesAndOhs.XO("xxOo"));
            Assert.AreEqual(false, ExesAndOhs.XO("xxxm"));
            Assert.AreEqual(false, ExesAndOhs.XO("Oo"));
            Assert.AreEqual(false, ExesAndOhs.XO("ooom"));
            Assert.AreEqual(false, ExesAndOhs.XO("xxx"));
            Assert.AreEqual(false, ExesAndOhs.XO(""));
        }
    }
}