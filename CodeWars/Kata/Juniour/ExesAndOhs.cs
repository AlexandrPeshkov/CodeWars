using System.Linq;

namespace CodeWars.Kata.Juniour
{
    public class ExesAndOhs
    {
        public static bool XO(string input)
        {
            const char _o = 'o';
            const char _x = 'x';

            int _oCount = 0;
            int _xCount = 0;

            foreach (var letter in input.ToLower())
            {
                if (letter == _o)
                {
                    _oCount++;
                }

                if (letter == _x)
                {
                    _xCount++;
                }
            }

            if (_oCount == 0 && _xCount == 0)
            {
                return false;
            }

            return _oCount == _xCount;
        }
    }
}