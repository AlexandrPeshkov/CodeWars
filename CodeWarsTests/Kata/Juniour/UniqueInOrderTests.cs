using System.Collections.Generic;
using CodeWars.Kata.Juniour;
using NUnit.Framework;

namespace CodeWarsTests.Kata.Juniour
{
    public class UniqueInOrderTests : BaseTest
    {
        public override void RunTests()
        {
            Assert.AreEqual("", UniqueInOrderSolution.UniqueInOrder(""));
            Assert.AreEqual("ABCDAB", UniqueInOrderSolution.UniqueInOrder("AAAABBBCCDAABBB"));

            Assert.AreEqual(new List<string> { "A", "B", null, "" },
                UniqueInOrderSolution.UniqueInOrder(new List<string> { "A", "B", "B", null, "" }));
        }
    }
}