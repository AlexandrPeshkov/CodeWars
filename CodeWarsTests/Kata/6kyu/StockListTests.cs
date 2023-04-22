using NUnit.Framework;

[TestFixture]
public class StockListTests
{
    [Test]
    public void Test1()
    {
        var art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
        var cd = new string[] { "A", "B" };
        Assert.AreEqual("(A : 200) - (B : 1140)", StockList.stockSummary(art, cd));
    }
}