using System;
using System.Text;

namespace Sypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var encryptedText = new StringBuilder();
            foreach (var letter in text)
            {
                encryptedText.Append((char)(letter + 3));
            }
            Console.WriteLine(encryptedText);
        }
    }
}
