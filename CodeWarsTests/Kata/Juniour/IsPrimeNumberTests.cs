using System.Collections.Generic;
using CodeWars.Kata.Juniour;
using NUnit.Framework;

namespace CodeWarsTests.Kata.Juniour
{
    [TestFixture]
    public class IsPrimeNumberTests
    {
        private static IEnumerable<TestCaseData> SampleTestCases
        {
            get
            {
                yield return new TestCaseData(0).Returns(false);
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(2).Returns(true);
            }
        }

        [Test]
        [TestCaseSource(nameof(SampleTestCases))]
        public bool SampleTest(int n)
        {
            return IsPrimeNumber.IsPrime(n);
        }
    }
}