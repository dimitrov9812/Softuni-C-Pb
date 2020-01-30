using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
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
                    case "Add":
                        int numberToAdd = int.Parse(splittedCommand[1]);
                        list.Add(numberToAdd);
                        break;
                    case "Remove":
                        int index = int.Parse(splittedCommand[1]);
                        if (index >= 0 && index <= list.Count)
                        {
                            list.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    
                    case "Insert":
                        int numberToInsert = int.Parse(splittedCommand[1]);
                        int indexToInsert = int.Parse(splittedCommand[2]);
                        if (indexToInsert >= 0 && indexToInsert <= list.Count)
                        {
                            list.Insert(indexToInsert, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        

                        break;
                    case "Shift":
                        if (splittedCommand[1] == "Left")
                        {
                            int numberOfTimesLeft = int.Parse(splittedCommand[2]);
                            for (int i = 0; i < numberOfTimesLeft; i++)
                            {
                                list.Add(list[0]);
                                list.RemoveAt(0);
                            }
                        }

                        else if (splittedCommand[1] == "Right")
                        {
                            int numberOfTimesRight = int.Parse(splittedCommand[1]);
                            
                            for (int i = 0; i < numberOfTimesRight; i++)
                            {
                                list.Insert(0, list[list.Count - 1]);
                                list.RemoveAt(list.Count - 1);
                            }
                        }
                        break;
                  
                }

            }
            Console.WriteLine(string.Join(" ", list));
        }
        
        
    }
}
