using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            
            int size = numbers.Count / 2;
            for (int i = 0; i < size; i++)
            {
                numbers[i] += numbers[numbers.Count -1];             
                numbers.Remove(numbers[numbers.Count-1]);
            
                
            }
            //if (numbers.Count % 2 == 1)
            //{
            //    numbers.Add(numbers[numbers.Count / 2 + 1]);
            //}
            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
