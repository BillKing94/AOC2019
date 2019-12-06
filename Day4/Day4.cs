//#define testinput

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day4
{
    class Program
    {
        #region input
#if testinput

#else
        const string input = "236491-713787";
#endif
        #endregion

        static void Main(string[] args)
        {
            var range = input.Split("-").Select(str => int.Parse(str)).ToArray();

            var doubleNumber = new Regex("(.)\\1", RegexOptions.Compiled);

            bool meetsConditions(int i)
            {
                var str = i.ToString();
                if (str.Length != 6) return false;

                var doubleChars = doubleNumber.Matches(str).Select(m => m.Value[0]).ToArray();
                if (!doubleChars.Any()) return false;
                if (!str.Any(c1 => str.Count(c2 => c1 == c2) == 2)) return false;

                for (int iChar = 0; iChar < str.Length - 1; iChar++)
                {
                    if (str[iChar] > str[iChar + 1]) return false;
                }

                return true;
            }

            int nMatches = 0;
            for (int value = range[0]; value <= range[1]; value++)
            {
                if (meetsConditions(value)) nMatches++;
            }

            Console.WriteLine(nMatches);
        }
    }
}
