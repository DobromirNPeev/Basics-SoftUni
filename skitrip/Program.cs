using System;

namespace skitrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0;
            switch (type)
            {
                case "room for one person":
                    if (rating=="positive")
                    {
                        price = (day - 1) *18;
                        price = price + 0.25 * price;
                        Console.WriteLine("{0:f2}",price);
                    }
                    else if(rating=="negative")
                    {
                        price = (day - 1) *18*0.9;
                        Console.WriteLine("{0:f2}", price);
                    }
                    break;
                case "apartment":
                    if(day-1<10)
                    {
                        if(rating=="positive")
                        {
                            price = (day - 1) * 25 * 0.7;
                            price = price + price * 0.25;
                            Console.WriteLine("{0:f2}", price);
                        }
                        else if (rating=="negative")
                        {
                            price = (day - 1) * 25 * 0.7;
                            Console.WriteLine("{0:f2}", price);
                        }
                    }
                    else if(day-1>=10 && day-1<=15)
                    {
                        if (rating == "positive")
                        {
                            price = (day - 1) * 25 * 0.65;
                            price = price + price * 0.25;
                            Console.WriteLine("{0:f2}", price);
                        }
                        else if (rating == "negative")
                        {
                            price = (day - 1) * 25 * 0.9*0.65;
                            Console.WriteLine("{0:f2}", price);
                        }
                    }
                    else if(day-1>15)
                    {
                        if (rating == "positive")
                        {
                            price = (day - 1) * 25 * 0.5;
                            price = price + price * 0.25;
                            Console.WriteLine("{0:f2}", price);
                        }
                        else if (rating == "negative")
                        {
                            price = (day - 1) * 25 * 0.9*0.5;
                            Console.WriteLine("{0:f2}", price);
                        }
                    }
                    break;
                case "president apartment":
                    if (day - 1 < 10)
                    {
                        if (rating == "positive")
                        {
                            price = (day - 1) * 35 * 0.9;
                            price = price + price * 0.25;
                            Console.WriteLine("{0:f2}", price);
                        }
                        else if (rating == "negative")
                        {
                            price = (day - 1) * 35 * 0.9 * 0.9;
                            Console.WriteLine("{0:f2}", price);
                        }
                    }
                    else if (day - 1 >= 10 && day - 1 <= 15)
                    {
                        if (rating == "positive")
                        {
                            price = (day - 1) * 35 * 0.85;
                            price = price + price * 0.25;
                            Console.WriteLine("{0:f2}", price);
                        }
                        else if (rating == "negative")
                        {
                            price = (day - 1) * 35 * 0.9 * 0.85;
                            Console.WriteLine("{0:f2}", price);
                        }
                    }
                    else if (day - 1 > 15)
                    {
                        if (rating == "positive")
                        {
                            price = (day - 1) * 35 * 0.8;
                            price = price + price * 0.25;
                            Console.WriteLine("{0:f2}", price);
                        }
                        else if (rating == "negative")
                        {
                            price = (day - 1) * 35 *0.8*0.9;
                            Console.WriteLine("{0:f2}", price);
                        }
                    }
                    break;

            }
        }
    }
}
