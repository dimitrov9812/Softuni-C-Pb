using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string result = MiddleCharacter(word);
            Console.WriteLine(result);

        }
        static string MiddleCharacter(string word)
        {
            string middleCharacters = "";
            
                if (word.Length % 2 == 1)
                {
                    middleCharacters += word[word.Length / 2];
                }
                else if(word.Length%2 == 0)
                {
                middleCharacters += word[(word.Length / 2) - 1];
                middleCharacters += word[word.Length / 2] ;
               
                }
            return middleCharacters;
        }
    }
}
