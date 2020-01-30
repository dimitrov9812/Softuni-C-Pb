using System;
using System.Text;

namespace ReplacingRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var newText = new StringBuilder();
            for (int i = 0; i <text.Length; i++)
            {
                char current = text[i];
                if (i < text.Length-1)
                {
                    char next = text[i + 1];
                    if(current != next)
                    {
                        newText.Append(current);
                        continue;
                    }
                    else if (current == next)
                    {
                        text = text.Remove(text.IndexOf(current),1);
                        if(i != 0)
                        {
                            i-=2;
                        }
                    }
                    
                }
            }
            Console.WriteLine(text);
        }
    }
}
