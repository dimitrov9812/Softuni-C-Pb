using System;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the corners
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            //calculate 
            double length = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2);
            double area = length * width;
            double perimeter = length * 2 + width * 2;
            //print
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
