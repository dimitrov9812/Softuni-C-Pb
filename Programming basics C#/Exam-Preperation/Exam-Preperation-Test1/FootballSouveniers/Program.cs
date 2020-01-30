using System;

namespace FootballSouveniers
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            string stockName = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            double fullPrice;
            double flagPrice;
            double capPrice;
            double posterPrice;
            double stickerPrice;
            switch(teamName)
            {
                case "Argentina":
                    flagPrice = 3.25;
                    capPrice = 7.20;
                    posterPrice = 5.10;
                    stickerPrice = 1.25;
                    switch (stockName)
                    {
                        case "flags":
                            fullPrice = flagPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number,stockName,teamName,fullPrice);
                            break;
                        case "caps":
                            fullPrice = capPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "posters":
                            fullPrice = posterPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "stickers":
                            fullPrice = stickerPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }
                    break;
                case "Brazil":
                    flagPrice = 4.20;
                    capPrice = 8.50;
                    posterPrice = 5.35;
                    stickerPrice = 1.20;
                    switch (stockName)
                    {
                        case "flags":
                            fullPrice = flagPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "caps":
                            fullPrice = capPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "posters":
                            fullPrice = posterPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "stickers":
                            fullPrice = stickerPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }
                    break;
                case "Croatia":
                    flagPrice = 2.75;
                    capPrice = 6.90;
                    posterPrice = 4.95;
                    stickerPrice = 1.10;
                    switch (stockName)
                    {
                        case "flags":
                            fullPrice = flagPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "caps":
                            fullPrice = capPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "posters":
                            fullPrice = posterPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "stickers":
                            fullPrice = stickerPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }
                    break;
                case "Denmark":
                    flagPrice = 3.10;
                    capPrice = 6.50;
                    posterPrice = 4.80;
                    stickerPrice = 0.90;
                    switch (stockName)
                    {
                        case "flags":
                            fullPrice = flagPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "caps":
                            fullPrice = capPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "posters":
                            fullPrice = posterPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", number, stockName, teamName, fullPrice);
                            break;
                        case "stickers":
                            fullPrice = stickerPrice * number;
                            Console.WriteLine("Pepi bought {0} {1} of {2} for {3} lv.", number, stockName, teamName, fullPrice);
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Invalid country!");
                    break;

            }
        }
    }
}
