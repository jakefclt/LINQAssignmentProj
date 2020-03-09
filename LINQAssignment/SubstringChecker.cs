using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    public class SubstringChecker
    {
        public delegate bool WordsWithSubstringTh(string s);

        public static IEnumerable<string> CheckWord(List<string> words, WordsWithSubstringTh wordsToCheck)
        {
            foreach (var substring in words)
            {
                if (wordsToCheck(substring))
                {
                    yield return substring;
                }
            }
        }

        public static bool ContainsTh(string substring)
        {
            return substring.Contains("th");
        }

    }
}
