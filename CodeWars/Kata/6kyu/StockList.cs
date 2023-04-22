using System.Collections.Generic;
using System.Linq;

//https://www.codewars.com/kata/54dc6f5a224c26032800005c/train/csharp
public class StockList
{
    private const string pairFormat = "({0} : {1})";
    private const string space = " ";

    public static string stockSummary(string[] lstOfArt, string[] lstOf1stLetter)
    {
        if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0)
        {
            return string.Empty;
        }
        var categoryAmount = new Dictionary<string, int>(lstOf1stLetter.Length);

        foreach (string code in lstOf1stLetter)
        {
            categoryAmount[code] = 0;
        }

        foreach (string bookCode in lstOfArt)
        {
            string[] split = bookCode.Split(space);
            string categoryCode = split[0][0].ToString();

            if (lstOf1stLetter.Contains(categoryCode))
            {
                var amount = int.Parse(split[1]);
                categoryAmount[categoryCode] += amount;
            }
        }

        var result = string.Join(" - ", categoryAmount.Select(x => string.Format(pairFormat, x.Key, x.Value)));
        return result;
    }
}