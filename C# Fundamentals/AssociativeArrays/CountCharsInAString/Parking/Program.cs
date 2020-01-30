using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var carInfo = new Dictionary<string, string>();
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                string[] splittedInput = input.Split(' ').ToArray();
                string command = splittedInput[0];
                switch (command)
                {
                   
                    case "register":
                        string name = splittedInput[1];
                        string licensePlate = splittedInput[2];
                        if (!carInfo.ContainsKey(name))
                        {
                            carInfo.Add(name, licensePlate);
                            Console.WriteLine($"{name} registered {licensePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {carInfo[name]}");
                        }
                        break;
                    case "unregister":
                        name = splittedInput[1];
                        if (!carInfo.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        else
                        {
                            carInfo.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (var kvp in carInfo)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
