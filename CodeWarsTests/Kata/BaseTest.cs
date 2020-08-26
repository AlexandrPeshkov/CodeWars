using NUnit.Framework;
using System;

namespace CodeWarsTests.Kata
{
    [TestFixture]
    public abstract class BaseTest
    {
        private const int _iterationCount = 10000;

        [Test]
        public abstract void RunTests();

        [Test]
        public void Perfomance()
        {
            for (var i = 0; i < _iterationCount; i++)
            {
                RunTests();
            }
        }
    }
}