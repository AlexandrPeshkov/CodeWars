using NUnit.Framework;
using System;

namespace CodeWarsTests.Kata
{
    [TestFixture]
    public abstract class BaseTest
    {
        private const int _iterationCount = 10000;

        public void Perfomance(Action action)
        {
            for (var i = 0; i < _iterationCount; i++)
            {
                action();
            }
        }
    }
}