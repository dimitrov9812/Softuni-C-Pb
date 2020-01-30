using System;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter quantity
            double vacPrice = double.Parse(Console.ReadLine());
            int puzzleQty = int.Parse(Console.ReadLine());
            int speakingDollQty = int.Parse(Console.ReadLine());
            int teddybearsQty = int.Parse(Console.ReadLine());
            int minionQty = int.Parse(Console.ReadLine());
            int truckQty = int.Parse(Console.ReadLine());
            int orderQty = puzzleQty + speakingDollQty + teddybearsQty + minionQty + truckQty;
            //enter store prices 
            double puzzlePrice = 2.60*puzzleQty;
            double speakingDollPrice = 3*speakingDollQty;
            double teddybearPrice = 4.10*teddybearsQty;
            double minionPrice = 8.20*minionQty;
            double truckPrice = 2*truckQty;
            double fullOrderPrice = puzzlePrice + speakingDollPrice + teddybearPrice + minionPrice + truckPrice;
            double rent = 10 / 100;
            double discount = 25 / 100;

           //calculate
           if(orderQty>= 50)
            {
                double newprice = fullOrderPrice - discount*fullOrderPrice - rent*fullOrderPrice;
                double moneyleft = vacPrice - newprice;
                double moneyneeded = newprice - vacPrice;
                if(newprice <= vacPrice)
                {
                    Console.WriteLine("Yes! "+ moneyleft +" lv left.");
                }
                else if(newprice >= vacPrice)
                {
                    Console.WriteLine("Not enough money! " + moneyneeded+" lv needed.");
                }

            }
           else if (orderQty < 50)
            {
                double newprice = fullOrderPrice - fullOrderPrice * rent;
                double moneyleft = vacPrice - newprice;
                double moneyneeded = vacPrice - newprice;
                if (newprice <= vacPrice)
                {
                    Console.WriteLine("Yes! " + moneyleft + " lv left.");
                }
                else if (newprice >= vacPrice)
                {
                    Console.WriteLine("Not enough money! " + moneyneeded + " lv needed.");
                }
            }

           //check
           //print
        }
    }
}
