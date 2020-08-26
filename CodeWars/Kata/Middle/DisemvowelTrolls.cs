using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars.Kata.Middle
{
    public class DisemvowelTrolls
    {
        private static char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        //32
        public static string Disemvowel(string str)
        {
            return string.Join(string.Empty, str.Where(x => vowels.Contains(x) == false));
            //return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }
    }
}