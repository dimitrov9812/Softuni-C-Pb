using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Guests = new List<string>();

            int commands = int.Parse(Console.ReadLine());
            while (commands >= 0)
            {
                string order = Console.ReadLine();
                string[] splitOrder = order.Split();
                string guestName = splitOrder[0];
                if (splitOrder.Count() == 3)
                {
                    if (Guests.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    else
                    {
                        Guests.Add(guestName);
                    }
                }
                else
                {
                    if (Guests.Contains(guestName))
                    {
                        Guests.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                 
                    }
                }
                commands -=1;

            }
            for (int i = 0; i < Guests.Count; i++)
            {
                Console.WriteLine(Guests[i]);
            }
        }
    }
}
