using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            bool changesMade = false;
            while (command != "end")
            {
                command = Console.ReadLine();
               
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        changesMade = true;
                        break;
                        
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        changesMade = true;
                        break;
                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemoveAt);
                        changesMade = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        changesMade = true;
                        break;
                    case "Contains":
                        int numberToCheck = int.Parse(tokens[1]);
                        bool contains = numbers.Contains(numberToCheck);
                        if (contains == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        PrintEven(numbers);
                        break;         
                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;
                    case "GetSum":
                        Console.WriteLine(GetSum(numbers));
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int numToEqual = int.Parse(tokens[2]);
                        PrintCondition(numbers, condition, numToEqual);
                        break;                  
                }
            }
            if(changesMade== true)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
        static void PrintEven(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i]%2 == 0)
                {
                    Console.Write(list[i]+" ");
                }
            }
            Console.WriteLine();

        }
        static void PrintOdd(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    Console.Write(list[i] + " ");
                }
            }
            Console.WriteLine();

        }
        static int GetSum(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }
        static void PrintCondition(List<int> list,string condition,int number)
        {
            switch (condition)
            {
                case ">":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] > number)
                        {
                            Console.Write(list[i]+" ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case "<":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] < number)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">=":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] >= number)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case "<=":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= number)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
            }
            
        }


    }
}
