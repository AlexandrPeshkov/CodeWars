using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kata.Middle
{
    public class CountingDuplicates
    {
        /// <summary>
        /// Write a function that will return the count of distinct case-insensitive
        /// alphabetic characters and numeric digits that occur more than once in the input string.
        /// The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
        /// https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int DuplicateCount_(string str)
        {
            return str.ToLower().ToCharArray().GroupBy(x => x).Select(x => x.Count()).Where(x => x > 1).Count();
        }

        public static int DuplicateCount__(string str)
        {
            int[] counter = new int[128];

            foreach (var letter in str)
            {
                counter[char.ToLower(letter)]++;
            }
            return counter.Count(x => x > 1);
        }

        public static int DuplicateCount(string str)
        {
            Dictionary<char, uint> letterCount = new Dictionary<char, uint>(str.Length);

            foreach (var letter in str)
            {
                char lowerLetter = char.ToLower(letter);
                if (letterCount.TryGetValue(lowerLetter, out var counter))
                {
                    letterCount[lowerLetter] = ++counter;
                }
                else
                {
                    letterCount.Add(lowerLetter, 1);
                }
            }

            return letterCount.Count(x => x.Value > 1);
        }
    }
}