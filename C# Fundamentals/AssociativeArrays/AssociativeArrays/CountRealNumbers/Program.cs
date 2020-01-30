using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().
                Split(' ').
                Select(double.Parse).
                ToArray();

            var counts = new SortedDictionary<double, int>();
            
            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }
            foreach (var number in counts)
            { 
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
