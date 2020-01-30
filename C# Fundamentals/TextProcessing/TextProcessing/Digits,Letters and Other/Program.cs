using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            var digits = new StringBuilder();
            var letters = new StringBuilder();
            var others = new StringBuilder();
            foreach (var word in words)
            {
                if ((int)word >= 48 && (int)word <= 57)
                {
                    digits =digits.Append(word);
                }
                else if (((int)word >= 97 && (int)word <= 122 )|| ((int)word>=65&& (int)word<=90))
                {
                    letters =letters.Append(word);
                }
                else
                {
                    others =others.Append(word);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
        
    }
}
