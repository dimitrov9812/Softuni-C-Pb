using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            AllInBetween(a, b);
        }
        static void AllInBetween(char a, char b)
        {
            int start = (int)a;
            int end = (int)b;
            for (int i = start+1; i < end; i++)
            {
                Console.Write((char)i +" ");
            }
            Console.WriteLine();
        }
    }
}
