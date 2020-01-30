using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            while(number != "END")
            {
                bool isPal = IsPalindrome(number);

                if (isPal == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                number = Console.ReadLine();
            }
        }
        static bool IsPalindrome(string number)
        {
            string normalnum = "";
            string reversednum = "";
            for (int i = 0; i < number.Length; i++)
            {
                char currentNum = number[i];
                normalnum += currentNum;
            }
            for (int i = number.Length-1; i >= 0; i--)
            {
                char currentNum = number[i];
                reversednum += currentNum;
               
            }
            if (normalnum == reversednum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
