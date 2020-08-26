using CodeWars.Kata.Middle;
using NUnit.Framework;

namespace CodeWarsTests.Kata.Middle
{
    internal class DuplicateEncoderTests : BaseTest
    {
        [Test]
        public override void RunTests()
        {
            Assert.AreEqual("(((", DuplicateEncoder.DuplicateEncode("din"));
            Assert.AreEqual("()()()", DuplicateEncoder.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", DuplicateEncoder.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", DuplicateEncoder.DuplicateEncode("(( @"));
        }
    }
}