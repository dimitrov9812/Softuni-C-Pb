using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int goal =  10000;
            int steps = 0;
            int count = 0;
            while (steps<goal)
            {
                string command = Console.ReadLine();
                if(command=="Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    if (steps >= goal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                    else
                    {
                        int diff = goal - steps;
                        Console.WriteLine("{0} more steps to reach goal.",diff);
                    }
                }
                else
                {
                    steps += int.Parse(command);
                    if(steps >= goal)
                        Console.WriteLine("Goal reached! Good job!");
                }

            }
        }
    }
}
