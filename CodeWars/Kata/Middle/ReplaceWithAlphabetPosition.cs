using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.Kata.Middle
{
    //https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp
    public class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition__(string text)
        {
            var alphabet = new List<char>();
            alphabet.AddRange("abcdefghijklmnopqrstuvwxyz");

            return string.Join(' ', text.ToLower().ToCharArray().Select(x => alphabet.IndexOf(x) + 1).Where(x => x > 0));
        }

        public static string AlphabetPosition_(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }

        public static string AlphabetPosition(string text)
        {
            if (text.Length == 0)
            {
                return string.Empty;
            }
            StringBuilder builder = new StringBuilder(text.Length * 3);
            //const string space = " ";
            foreach (var letter in text.ToLower())
            {
                if (char.IsLetter(letter))
                {
                    //builder.Append(letter - 96);
                    builder.Append(letter & 31);
                    builder.Append(32);
                }
            }

            if (builder.Length > 1)
            {
                return builder.Remove(builder.Length - 1, 1).ToString();
            }
            return string.Empty;
        }
    }
}