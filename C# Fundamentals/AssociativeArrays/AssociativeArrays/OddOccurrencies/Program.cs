using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().
                Split(' ').
                ToArray();
            var count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string wordToLower = word.ToLower();
                if (count.ContainsKey(wordToLower))
                {
                    count[wordToLower]++;
                }
                else
                {
                    count.Add(wordToLower, 1);
                }
            }
            foreach (var word in count)
            {
                if(word.Value % 2 == 1)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
