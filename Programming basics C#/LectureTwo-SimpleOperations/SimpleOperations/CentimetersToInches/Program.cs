using System;

namespace CentimetersToInches
{
    class Program
    {
        static void Main(string[] args)
        {
            double Inches = double.Parse(Console.ReadLine());
            double Centimeters = Inches * 2.54;
            Console.WriteLine("{0:F2}",Centimeters);
        }
    }
}
