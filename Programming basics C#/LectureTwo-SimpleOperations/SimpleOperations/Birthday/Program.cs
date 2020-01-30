using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = (lenght * width * height)*0.001;
            double result = volume * (1 - (percent * 0.01));
            Console.WriteLine("{0:F3}",result);
        }
    }
}
