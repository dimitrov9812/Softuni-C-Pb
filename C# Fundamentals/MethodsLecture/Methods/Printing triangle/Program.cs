using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            firstHalf(input);
            SecondHalf(input);
            

        }
        static void firstHalf(int input)
        {
            for (int rows = 1; rows <= input; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(cols);
                }
                Console.WriteLine();
            }
        }
        static void SecondHalf(int input)
        {
            for (int rows = input - 1; rows >= 1; rows--)
            {
                        for (int cols = 1; cols <= rows; cols++)
                    {
                         Console.Write(cols);
                    }
                        Console.WriteLine();
            }


        }

    }
}
