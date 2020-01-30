using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(VowelCount(text));          
        }
        static int VowelCount(string text)
        {   
            int vowCount = 0;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            string textToLower = AllToLower(text);
            for (int i = 0; i < textToLower.Length; i++)
            {
                char currentChar = textToLower[i];
                foreach (var character in vowels)
                {
                    if(character == currentChar)
                    {
                        vowCount += 1;
                    }
                }
            }
            return vowCount;
        }
        static string AllToLower(string text)
        {
            string textToLower = text.ToLower();
            return textToLower;
        }
    }
}
