using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }
        static void Matrix(int n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
