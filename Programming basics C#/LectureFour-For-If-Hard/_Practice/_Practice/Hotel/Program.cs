//using System;

//namespace Hotel
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string month = Console.ReadLine();
//            int days = int.Parse(Console.ReadLine());
//            double flatPrice = 0;
//            double studioPrice = 0;
//            double finalPrice = 0;
//            switch (month)
//            {
//                case "May":
//                case "October":
//                    flatPrice = 65.00;
//                    studioPrice = 50.00;
//                    if(days > 7 && days <= 14)
//                    {
//                        studioPrice = days*(studioPrice - (studioPrice * 0.05));
//                        flatPrice = days * flatPrice;
//                        Console.WriteLine("Apartment: {0:f2} lv.", flatPrice);
//                        Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
//                    }
//                    else if (days > 14)
//                    {
//                        studioPrice = days * (studioPrice - (studioPrice * 0.30));
//                        flatPrice = days * (flatPrice-(flatPrice*0.10));
//                        Console.WriteLine("Apartment: {0:f2} lv.", flatPrice);
//                        Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
//                    }
//                    else
//                    {
//                        studioPrice = days * studioPrice;
//                        flatPrice = days * flatPrice;
//                        Console.WriteLine("Apartment: {0:f2} lv.", flatPrice);
//                        Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
//                    }
//                    break;
//                case "June":
//                case "Semptember":
//                    studioPrice = 75.20;
//                    flatPrice = 68.70; 
//                    if(days > 14)
//                    {
//                        studioPrice = days*(studioPrice - (studioPrice * 0.20));
//                        flatPrice = days * (flatPrice - (flatPrice*0.10));
//                        Console.WriteLine("Apartment: {0:f2} lv.", flatPrice);
//                        Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
//                    }
//                    else
//                    {
//                        studioPrice = days * studioPrice;
//                        flatPrice = days * flatPrice;
//                        Console.WriteLine("Apartment: {0:f2} lv.", flatPrice);
//                        Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
//                    }
//                    break;
//                case "Juli":
//                case "August":
//                    studioPrice = 76.00;
//                    flatPrice = 77.00;
//                    if (days > 14)
//                    {
//                        flatPrice = days * (flatPrice - (flatPrice * 0.10));
//                        studioPrice = days * studioPrice;
//                        Console.WriteLine("Apartment: {0:f2} lv.", flatPrice);
//                        Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
//                    }
//                    else
//                    {
//                        flatPrice = days * flatPrice;
//                        studioPrice = days * studioPrice;
//                        Console.WriteLine("Apartment: {0:f2} lv.", flatPrice);
//                        Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
//                    }
//                    break;
//            }

//        }
//    }
//}

