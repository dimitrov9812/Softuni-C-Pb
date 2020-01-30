using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "end") 
            {
                string[] splittedCommand = command.Split(' ');
                switch (splittedCommand[0])
                {
                    case "Delete":
                        int numberToDelete = int.Parse(splittedCommand[1]);
                        for (int i = 0; i < list.Count; i++)
                        {

                            if(list[i] == numberToDelete)
                            {
                                list.Remove(numberToDelete);
                                i -= 1;
                            }
                        }
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(splittedCommand[1]);
                        int indexToInsert = int.Parse(splittedCommand[2]);
                        list.Insert(indexToInsert, numberToInsert);

                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
