using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace CodeWars.Kata.Middle
{
    //The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")"
    //if that character appears more than once in the original string.
    //Ignore capitalization when determining if a character is a duplicate.
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            Dictionary<char, int> charsCnt = new Dictionary<char, int>();
            foreach (var chr in word.ToLower())
            {
                if (charsCnt.TryGetValue(chr, out int val))
                {
                    charsCnt[chr]++;
                }
                else
                {
                    charsCnt.Add(chr, 1);
                }
            }
            return string.Join(string.Empty, word.ToLower().Select(x => charsCnt[x] > 1 ? ')' : '('));
        }

        public static string DuplicateEncode_(string word)
        {
            Dictionary<char, uint> letterCount = new Dictionary<char, uint>(word.Length);
            const char _right = ')';
            const char _left = '(';

            string lowerStr = word.ToLower();

            foreach (var letter in lowerStr)
            {
                if (letterCount.TryGetValue(letter, out var counter) == false)
                {
                    letterCount.Add(letter, 1);
                }
                else
                {
                    letterCount[letter] = ++counter;
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var letter in lowerStr)
            {
                if (letterCount[letter] > 1)
                {
                    stringBuilder.Append(_right);
                }
                else
                {
                    stringBuilder.Append(_left);
                }
            }
            return stringBuilder.ToString();
        }
    }
}