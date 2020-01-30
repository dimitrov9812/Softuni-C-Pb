using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    GetMax(a, b);
                    break;
                case "char":
                    char first = char.Parse(Console.ReadLine());
                    char second= char.Parse(Console.ReadLine());
                    GetMax(first, second);
                    break;
                case "string":
                    string fstring = Console.ReadLine();
                    string sstring = Console.ReadLine();
                    GetMax(fstring, sstring);
                    break;
                default:
                    break;
            }
        }
        static void GetMax(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        static void GetMax(char first, char second)
        {
            CharToValue(first, second);
        }
        static void GetMax(string fstring, string sstring)
        {
            StringToValue(fstring, sstring);
        }
        static void StringToValue(string a,string b)
        {
            int first = 0;
            int second = 0;
            for (int i = 0; i < a.Length; i++)
            {
                first += (int)a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                second += (int)b[i];
            }
            if(first> second)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        static void CharToValue(char a, char b)
        {
            int first = (int)a;
            int second = (int)b;
            if (first > second)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }

    }
}
