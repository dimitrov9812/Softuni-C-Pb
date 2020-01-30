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
            string input;
            var output = new Dictionary<string, string>();
            while ((input = Console.ReadLine()) != "end")
            {
                var currentWord = input;
                string reversedWord = "";
                char[] charArray = currentWord.ToCharArray();
                Array.Reverse(charArray);
                foreach (var a in charArray)
                {
                    reversedWord += a;
                }
                output.Add(currentWord, reversedWord);
            }
            foreach (var kvp in output)
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value.ToString()}");
            }
            
            
        }
        
    }
}
