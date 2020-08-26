using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars.Kata.Middle
{
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
    }
}
