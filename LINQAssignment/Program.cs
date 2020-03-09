using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            IEnumerable<string> result = SubstringChecker.CheckWord(words, SubstringChecker.ContainsTh);

           
            foreach (string word in result)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }

        }
    }
}
