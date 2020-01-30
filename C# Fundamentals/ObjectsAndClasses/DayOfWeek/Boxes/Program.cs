using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public int PriceForABox { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] splittedInput = input.Split(' ');
                int serialNumber = int.Parse(splittedInput[0]);    
                string itemname = splittedInput[1];
                int quantity = int.Parse(splittedInput[2]);
                int price = int.Parse(splittedInput[3]);
                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    ItemQuantity = quantity,
                    PriceForABox = quantity * price,                  
                };
                Box item = new Item();
            }
        }
    }
}
