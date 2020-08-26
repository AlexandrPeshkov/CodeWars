using NUnit.Framework;
using System;

namespace CodeWarsTests.Kata
{
    [TestFixture]
    public class BaseTest
    {
        private const int _iterationCount = 10000;

        public void Preference(Action action)
        {
            for (var i = 0; i < _iterationCount; i++)
            {
                action();
            }
        }
    }
}