using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveString
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] wordToRemove = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            string sentence = Console.ReadLine();
            string stars = string.Empty;
            foreach (var word in wordToRemove)
            {
                stars = string.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    stars += '*';
                }
                while (sentence.Contains(word))
                {
                    sentence = sentence.Replace(word, stars);
                }
            }
            Console.WriteLine(sentence);
            //abchelloimabc
            
        }
    }
}
