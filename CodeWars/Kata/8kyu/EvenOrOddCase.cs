namespace CodeWars.Kata
{
    /// <summary>
    /// Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
    /// </summary>
    public class EvenOrOddCase
    {
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}