using System;
using System.Collections.Generic;
using System.Text;

//https://www.codewars.com/kata/51b62bf6a9c58071c600001b/train/csharp
public class RomanConvert
{
    public const string C = "C";

    public const string CD = "CD";

    public const string CM = "CM";

    public const string D = "D";

    public const string I = "I";

    public const string IV = "IV";

    public const string IX = "IX";

    public const string L = "L";

    public const string M = "M";

    public const string V = "V";

    public const string X = "X";

    public const string XC = "XC";

    public const string XL = "XL";

    private static readonly IReadOnlyDictionary<string, int> romanValues = new Dictionary<string, int>()
    {
        { M, 1000 },
        { CM, 900 },
        { D, 500 },
        { CD, 400 },
        { C, 100 },
        { XC, 90 },
        { L, 50 },
        { XL, 40 },
        { X, 10 },
        { IX, 9 },
        { V, 5 },
        { IV, 4 },
        { I, 1 }
    };

    /// <summary>
    /// n = [1, 3999]
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static string Solution(int n)
    {
        if ((n < 0) || (n > 3999)) throw new ArgumentOutOfRangeException();

        var stringBuilder = new StringBuilder();

        void Append(string digit)
        {
            int digitValue = romanValues[digit];
            int amount = n / digitValue;
            n -= amount * digitValue;

            for (var i = 0; i < amount; i++)
            {
                stringBuilder.Append(digit);
            }
        }

        if (n >= 1000) Append(M);

        if (n >= 900) Append(CM);

        if (n >= 500) Append(D);

        if (n >= 400) Append(CD);

        if (n >= 100) Append(C);

        if (n >= 90) Append(XC);

        if (n >= 50) Append(L);

        if (n >= 40) Append(XL);

        if (n >= 10) Append(X);

        if (n >= 9) Append(IX);

        if (n >= 5) Append(V);

        if (n >= 4) Append(IV);

        if (n >= 1) Append(I);

        return stringBuilder.ToString();
    }
}