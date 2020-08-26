using CodeWars.Kata.Juniour;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests.Kata.Juniour
{
    public class UniqueInOrderTests : BaseTest
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", UniqueInOrderSolution.UniqueInOrder(""));
        }

        [Test]
        public void SimleTest1()
        {
            Assert.AreEqual("ABCDAB", UniqueInOrderSolution.UniqueInOrder("AAAABBBCCDAABBB"));
        }

        [Test]
        public void NullTest1()
        {
            Assert.AreEqual(new List<string> { "A", "B", null, "" }, UniqueInOrderSolution.UniqueInOrder(new List<string> { "A", "B", "B", null, "" }));
        }
    }
}