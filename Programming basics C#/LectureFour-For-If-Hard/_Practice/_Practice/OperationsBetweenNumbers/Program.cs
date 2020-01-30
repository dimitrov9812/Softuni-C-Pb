using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01 = int.Parse(Console.ReadLine());
            double num02 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num01 + num02;
                    if (result % 2 == 0)
                    {                        
                        Console.WriteLine($"{num01} + {num02} = " +result +" - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num01} + {num02} = " +result + " - odd");
                    }
                    break;
                case '-':
                    result = num01 - num02;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{num01} - {num02} = " +result + " - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num01} - {num02} = " +result + " - odd");
                    }
                    break;
                case '*':
                    result = num01 * num02;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{num01} * {num02} = " + result + " - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num01} * {num02} = " + result + " - odd");
                    }
                    break;
                case '/':
                    result = num01 / num02;
                    if(num02!=0)
                    Console.WriteLine($"{num01} / {num02} = "+"{0:f2}",result);
                    else
                        Console.WriteLine("Cannot divide {0} by zero",num01);
                    break;
                case '%':
                    result = num01 % num02;
                    if (num02 != 0)
                        Console.WriteLine($"{num01} % {num02} = " + result);
                    else
                        Console.WriteLine("Cannot divide {0} by zero", num01);
                    break;
            }
        }
    }
}
