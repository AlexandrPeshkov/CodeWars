using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.Kata.Middle
{
    public class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            var alphabet = new List<char>();
            alphabet.AddRange("abcdefghijklmnopqrstuvwxyz");

            return string.Join(' ', text.ToLower().ToCharArray().Select(x => alphabet.IndexOf(x) + 1).Where(x => x > 0));
        }
    }
}
