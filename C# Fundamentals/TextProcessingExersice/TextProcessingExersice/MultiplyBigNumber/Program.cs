using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int n =int.Parse(Console.ReadLine());
            int temporaryResult = 0;
            string valueLeftString = "";
            string valueToAddString = "";
            int valueLeft = 0;
            int valueToAdd = 0;
            string temporaryToString = "";
            var result = new StringBuilder();
            var resultReversed = new StringBuilder();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                temporaryResult = 0;
                string currentNumberChar = number[i].ToString();//9
                int currentNumberInt = int.Parse(currentNumberChar);
                temporaryResult += (currentNumberInt * n) + valueLeft;//temporary = 9*9 = 81
                temporaryToString = temporaryResult.ToString();//string = 81
                if(temporaryToString.Length == 1)
                {
                    valueToAddString = temporaryToString[0].ToString();//1->9->
                    valueToAdd = int.Parse(valueToAddString);
                    if (i == 0)
                    {
                        result.Append(valueToAdd);
                    }
                    else
                    {
                        result.Append(valueToAdd);
                    }
                }
                else
                {
                    valueLeftString = temporaryToString[0].ToString();//8->8;
                    valueToAddString = temporaryToString[1].ToString();//1->9->
                    valueLeft = int.Parse(valueLeftString);
                    valueToAdd = int.Parse(valueToAddString);
                    if (i == 0)
                    {
                        result.Append(valueToAdd);
                        result.Append(valueLeft);
                        valueLeft = 0;
                    }
                    else
                    {
                        result.Append(valueToAdd);
                    }
                }
                
            }
            for (int i = result.Length-1; i >= 0; i--)
            {
                resultReversed.Append(result[i]);
            }
            Console.WriteLine(resultReversed);
        }
    }
}
