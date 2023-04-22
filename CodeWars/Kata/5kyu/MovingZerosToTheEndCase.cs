using System;

namespace CodeWars.Kata._5kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/526571aae218b8ee490006f4/train/csharp
    /// </summary>
    public class MovingZerosToTheEndCase
    {
        //Write a function that takes an integer as input, and returns the number of bits that
        //are equal to one in the binary representation of that number. You can guarantee that input is non-negative. 

        public static int CountOneBits(int n)
        {
            //var intSize = sizeof(int) * 8;

            var oneBitCount = 0;

            var mask = 0b_1;

            //var maskStr2 = Convert.ToString(mask, 2);

            float maxValueBit = MathF.Round(MathF.Log2(n));

            for (var i = 0; i < 32; i++)
            {
                // 0000_0000_0000_0000_0000_0000_0000_0100
                //

                //0000_1000
                //<<4
                //
                //var shift = (n >> i);
                int r = (n >> i) & mask;

                if (r == 1) oneBitCount++;

                // var numberStr2 = Convert.ToString(n, 2);
                // var shiftStr2 = Convert.ToString(shift, 2);
                // var resultStr2 = Convert.ToString(r, 2);
                //
                // Console.WriteLine($"Number {numberStr2,8}");
                // Console.WriteLine($"Shift {shiftStr2,8}");
                // Console.WriteLine($"Result {resultStr2,8}");
            }

            return oneBitCount;
        }
    }
}