using System;

namespace training
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i <= word.Length-1; i++)
            {
                char currentChar = word[i];
                int currentCharInValue = currentChar;
                sum += currentCharInValue;
                

            }
            Console.WriteLine(sum);
        }
    }
}
