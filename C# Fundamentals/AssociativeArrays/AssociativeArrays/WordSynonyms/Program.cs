using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string,List<string>>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if (!words.ContainsKey(key))
                {
                    words.Add(key, new List<string>());
                    words[key].Add(value);
                }
                else
                {
                    words[key].Add(value);
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
