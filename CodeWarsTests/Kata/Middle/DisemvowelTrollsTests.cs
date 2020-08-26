using CodeWars.Kata.Middle;
using NUnit.Framework;

namespace CodeWarsTests.Kata.Middle
{
    internal class DisemvowelTrollsTests : BaseTest
    {
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", DisemvowelTrolls.Disemvowel("This website is for losers LOL!"));
        }

        [Test]
        public void Preference()
        {
            base.Preference(ShouldRemoveAllVowels);
        }
    }
}