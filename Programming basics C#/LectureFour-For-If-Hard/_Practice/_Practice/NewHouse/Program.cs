using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double rosePrice = 5.00;
            double dahliaPrice = 3.80;
            double tulipPrice = 2.80;
            double narcissusPrice = 3.00;
            double gladiolusPrice = 2.50;
            double fullprice = 0;
            double moneyleft = 0;
            switch (type)
            {
                case "Roses":
                    if(numOfFlowers > 80)
                    {
                        fullprice = (numOfFlowers * rosePrice) - ((numOfFlowers * rosePrice) * 0.10);
                        if (budget >= fullprice)
                        {
                            moneyleft = budget - fullprice;
                            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.",numOfFlowers,type,moneyleft);
                        }
                        else
                        {
                            moneyleft = fullprice - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.",moneyleft);
                        }
                    }
                    else
                    {
                        fullprice = numOfFlowers * rosePrice;
                        if (budget >= fullprice)
                        {
                            moneyleft = budget - fullprice;
                            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numOfFlowers, type, moneyleft);
                        }
                        else
                        {
                            moneyleft = fullprice - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyleft);
                        }
                    }
                    break;
                case "Dahlias":
                    if (numOfFlowers > 90)
                    {
                        fullprice = (numOfFlowers * dahliaPrice) - ((numOfFlowers * dahliaPrice) * 0.15);
                        if (budget >= fullprice)
                        {
                            moneyleft = budget - fullprice;
                            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numOfFlowers, type, moneyleft);
                        }
                        else
                        {
                            moneyleft = fullprice - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyleft);
                        }
                    }
                    else
                    {
                        fullprice = numOfFlowers * dahliaPrice;
                        if (budget >= fullprice)
                        {
                            moneyleft = budget - fullprice;
                            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numOfFlowers, type, moneyleft);
                        }
                        else
                        {
                            moneyleft = fullprice - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyleft);
                        }
                    }
                    break;
                case "Tulips":
                    if (numOfFlowers > 80)
                    {
                        fullprice = (numOfFlowers * tulipPrice) - ((numOfFlowers * tulipPrice) * 0.15);
                        if (budget >= fullprice)
                        {
                            moneyleft = budget - fullprice;
                            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numOfFlowers, type,moneyleft);
                        }
                        else
                        {
                            moneyleft = fullprice - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyleft);
                        }
                    }
                    else
                    {
                        fullprice = numOfFlowers * tulipPrice;
                        if (budget > fullprice)
                        {
                            moneyleft = budget - fullprice;
                            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numOfFlowers, type, moneyleft);
                        }
                        else
                        {
                            moneyleft = fullprice - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyleft);
                        }
                    }
                    break;
                case "Narcissus":
                    if (numOfFlowers < 120)
                    {
                        fullprice = (numOfFlowers * narcissusPrice) + ((numOfFlowers * narcissusPrice) * 0.15);
                        if (budget >= fullprice)
                        {
                            moneyleft = budget - fullprice;
                            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numOfFlowers, type, moneyleft);
                        }
                        else
                        {
                            moneyleft = fullprice - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyleft);
                        }
                    }
                    else
                    {
                        fullprice =  numOfFlowers * narcissusPrice;
                        if (budget >= fullprice)
                        {
                            moneyleft = budget - fullprice;
                            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numOfFlowers, type, moneyleft);
                        }
                        else
                        {
                            moneyleft = fullprice - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyleft);
                        }
                    }
                    break;
                case "Gladiolus":
                    if (numOfFlowers < 80)
                    {
                        fullprice = (numOfFlowers * gladiolusPrice) + ((numOfFlowers * gladiolusPrice) * 0.20);
                        if (budget >= fullprice)
                        {
                            moneyleft = budget - fullprice;
                            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numOfFlowers, type, moneyleft);
                        }
                        else
                        {
                            moneyleft = fullprice - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyleft);
                        }
                    }
                    else
                    {
                        fullprice =  numOfFlowers * gladiolusPrice;
                        if (budget >= fullprice)
                        {
                            moneyleft = budget - fullprice;
                            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numOfFlowers, type, moneyleft);
                        }
                        else
                        {
                            moneyleft = fullprice - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyleft);
                        }
                    }
                    break;
            }
        }
    }
}
