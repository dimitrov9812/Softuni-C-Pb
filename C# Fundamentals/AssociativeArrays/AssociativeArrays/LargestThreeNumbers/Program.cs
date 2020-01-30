using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().
                  Split(' ').
                  Select(x => x + " ").
                  OrderByDescending(x => x).
                  Take(3).
                  ToList().
                ForEach(Console.Write);
                
        }
    }
}
