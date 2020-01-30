using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociativeArrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var count = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];
                if (!count.ContainsKey(currentChar) && currentChar!=' ')
                {
                    count.Add(currentChar,1);

                }
                else if(currentChar != ' ')
                {
                    count[currentChar]++;
                }
            }
            foreach (var kvp in count)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
