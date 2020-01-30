using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //number
            //string with metric type
            //ask for what type would be the desired printed value
            //print
            double number = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string convertTo = Console.ReadLine();
            switch (type)
            {
                case "mm":
                    
                    switch (convertTo)
                    {
                        case "cm":
                            Console.WriteLine("{0:F3}", number /10);
                            break;
                        case "m":
                            Console.WriteLine("{0:F3}", number / 1000);
                            break;
                    }
                    break;
                case "cm":
                    
                    switch (convertTo)
                    {
                        case "mm":
                            Console.WriteLine("{0:F3}", number * 10);
                            break;
                        case "m":
                            Console.WriteLine("{0:F3}", number /100);
                            break;
                    }
                    break;
                case "m":
                    switch (convertTo)
                    {
                        case "mm":
                            Console.WriteLine("{0:F3}",number *1000);
                            break;
                        case "cm":
                            Console.WriteLine("{0:F3}", number * 100);
                            break;
                    }
                    break;
            }
        }
    }
}
