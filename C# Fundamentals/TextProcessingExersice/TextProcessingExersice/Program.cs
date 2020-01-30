using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new char[]{',',' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            var symbols = new List<char>();
            bool isValid = true;
            for (int i = 33; i <=64; i++)
            {
                char charToAdd = (char)i;
                symbols.Add(charToAdd);
            }
            for (int i = 0; i < names.Count; i++)
            {
                string name = names[i];
                foreach (var symbol in symbols)
                {
                    if (name.Contains(symbol))
                    {
                        isValid = false;
                    }
                }
                if (isValid == false)
                {
                    names.Remove(name);
                }
                else
                    continue;
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
