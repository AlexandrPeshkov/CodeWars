using System;
using System.Collections.Generic;

namespace CodeWars.Kata.Juniour
{
    //The Western Suburbs Croquet Club has two categories of membership,
    //Senior and Open. They would like your help with an application form that
    //will tell prospective members which category they will be placed.
    //To be a senior, a member must be at least 55 years old and have a handicap greater than 7.
    //In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
    public class CategorizeNewMemberSolution
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            const string open = "Open";
            const string senior = "Senior";

            foreach (int[] person in data)
            {
                if (person?.Length == 2)
                {
                    if (person[0] >= 55 && person[1] > 7)
                        yield return senior;
                    else
                        yield return open;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(data), "The input should contain exactly 2 elements");
                }
            }
        }
    }
}