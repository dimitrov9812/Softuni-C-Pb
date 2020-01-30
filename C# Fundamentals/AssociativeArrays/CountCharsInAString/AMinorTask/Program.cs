using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new Dictionary<string, int>();
            while (true)
            {
                string resourse = Console.ReadLine();
                if(resourse == "stop")
                {
                    break;
                }
                int qty = int.Parse(Console.ReadLine());
                if (!values.ContainsKey(resourse))
                {
                    values.Add(resourse, qty);
                }
                else
                {
                    values[resourse] += qty;
                }
            }
            foreach (var kvp in values)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
