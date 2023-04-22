using NUnit.Framework;

[TestFixture]
public class RomanConvertTests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(500, "D")]
    [TestCase(1000, "M")]
    [TestCase(1954, "MCMLIV")]
    [TestCase(1990, "MCMXC")]
    [TestCase(2008, "MMVIII")]
    [TestCase(2014, "MMXIV")]
    [TestCase(735, "DCCXXXV")]
    public void Test(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }

    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(500, "D")]
    [TestCase(1000, "M")]
    [TestCase(1954, "MCMLIV")]
    [TestCase(1990, "MCMXC")]
    [TestCase(2008, "MMVIII")]
    [TestCase(2014, "MMXIV")]
    [TestCase(735, "DCCXXXV")]
    public void PerfomanceTest(int value, string expected, int repeated = 1000)
    {
        for (var i = 0; i < repeated; i++)
        {
            Assert.AreEqual(expected, RomanConvert.Solution(value));
        }
    }
}