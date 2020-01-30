using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegexExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>.+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
            string input;
            decimal total = 0;
            var furniture = new List<string>();
            while((input =Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int qty = int.Parse(match.Groups["quantity"].Value);
                    string name = match.Groups["name"].Value;
                    furniture.Add(name);
                    total += price * qty;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {total:F2}");
        }
    }
}
