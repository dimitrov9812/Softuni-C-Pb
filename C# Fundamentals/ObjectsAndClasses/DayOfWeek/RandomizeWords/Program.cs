using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> splittedInput = input.Split(' ').ToList();
            Random random = new Random();
            for (int i = 0; i < splittedInput.Count; i++)
            {
                int randomNumber = random.Next(0, splittedInput.Count);
                string current = splittedInput[i];
                splittedInput[i] = splittedInput[randomNumber];
                splittedInput[randomNumber] = current;
            }
            foreach (var item in splittedInput)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
