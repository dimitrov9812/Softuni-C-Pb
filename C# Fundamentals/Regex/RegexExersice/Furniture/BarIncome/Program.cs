using System;
using System.Text.RegularExpressions;

namespace BarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            //^% (?< name >[A - Z][a - z] +) %< (?< product >\w)>\| (?< count >\d +)\| (?< price >\d\.?\d +)\$$
            //@"(\W)(?<name>[A-Z][a-z]+)\1<(?<product>\w+)>(\W)(?<qty>\d+)\4(?<price>\d+\.?\d+)\W"
            string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<qty>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$";
            string input;
            decimal totalIncome = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string customer = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int qty = int.Parse(match.Groups["qty"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    Console.WriteLine($"{customer}: {product} - {qty * price:f2}");
                    totalIncome += qty * price;
                }

            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
