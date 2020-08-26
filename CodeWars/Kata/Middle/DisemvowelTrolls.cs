using System.Linq;

namespace CodeWars.Kata.Middle
{
    //Remove all vowels
    public class DisemvowelTrolls
    {
        private static readonly char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        //32
        public static string Disemvowel(string str)
        {
            return string.Join(string.Empty, str.Where(x => vowels.Contains(x) == false));
        }
    }
}