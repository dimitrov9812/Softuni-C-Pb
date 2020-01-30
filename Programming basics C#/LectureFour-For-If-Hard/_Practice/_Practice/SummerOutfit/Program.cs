using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            switch (timeOfDay)
            {
                case "Morning":
                    if(degrees>=10 && degrees <= 18)
                    {
                        Console.WriteLine("It's {0} degrees, get your Sweatshirt and Sneakers.",degrees);
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.",degrees);
                    }
                    else if (degrees >= 25)
                    {
                        Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degrees);
                    }
                    break;
                case "Afternoon":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degrees);
                    }
                    else if (degrees >= 25)
                    {
                        Console.WriteLine("It's {0} degrees, get your Swimsuit and Barefoot.", degrees);
                    }
                    break;
                case "Evening":
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                    break;

            }

        }
    }
}
