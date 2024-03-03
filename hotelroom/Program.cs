using System;

namespace hotelroom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double priceSt = 0;
            double priceApa = 0;
            switch (month)
            {
                case "May":
                    if(num>7 && num<=14)
                    {
                        priceApa = num * 65;
                        priceSt = num * 50 * 0.95;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    else if (num>14)
                    {
                        priceApa = num * 65*0.9;
                        priceSt = num * 50 * 0.7;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    else
                    {
                        priceApa = num * 65;
                        priceSt = num * 50;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    break;
                case "October":
                    if (num > 7 && num <= 14)
                    {
                        priceApa = num * 65;
                        priceSt = num * 50 * 0.95;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    else if (num > 14)
                    {
                        priceApa = num * 65 * 0.9;
                        priceSt = num * 50 * 0.7;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    else
                    {
                        priceApa = num * 65;
                        priceSt = num * 50;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    break;
                case "June":
                    if(num>14)
                    {
                        priceApa = num * 68.70 * 0.9;
                        priceSt = num * 75.20 * 0.8;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    else
                    {
                        priceApa = num * 68.70;
                        priceSt = num * 75.20;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    break;
                case "September":
                    if (num > 14)
                    {
                        priceApa = num * 68.70 * 0.9;
                        priceSt = num * 75.20 * 0.8;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    else
                    {
                        priceApa = num * 68.70;
                        priceSt = num * 75.20;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    break;
                case "July":
                    if(num>14)
                    {
                        priceApa = num * 77 * 0.9;
                        priceSt = num * 76;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    else
                    {
                        priceApa = num * 77;
                        priceSt = num * 76;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    break;
                case "August":
                    if (num > 14)
                    {
                        priceApa = num * 77 * 0.9;
                        priceSt = num * 76;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    else
                    {
                        priceApa = num * 77;
                        priceSt = num * 76;
                        Console.WriteLine($"Apartment: {priceApa,0:f2} lv.");
                        Console.WriteLine($"Studio: {priceSt,0:f2} lv.");
                    }
                    break;
            }
        }
        }
    }

