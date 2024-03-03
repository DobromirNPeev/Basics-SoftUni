using System;

namespace _03._Film_Premiere1
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string package = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double bill = 0;
            if(movie=="John Wick")
            {
                if (package == "Drink")
                {
                    bill = tickets * 12;
                    Console.WriteLine($"Your bill is {bill:f2} leva.");
                }
                else if (package == "Popcorn")
                {
                    bill = tickets * 15;
                    Console.WriteLine($"Your bill is {bill:f2} leva.");
                }
                else if (package == "Menu")
                {
                    bill = tickets * 19;
                    Console.WriteLine($"Your bill is {bill:f2} leva.");
                }
            }
            else if(movie=="Star Wars")
            {
                if (tickets >= 4)
                {
                    if (package == "Drink")
                    {
                        bill = tickets * 18;
                        bill = bill * 0.7;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                    else if (package == "Popcorn")
                    {
                        bill = tickets * 25;
                        bill = bill * 0.7;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                    else if (package == "Menu")
                    {
                        bill = tickets * 30;
                        bill = bill * 0.7;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                }
                else
                {
                    if (package == "Drink")
                    {
                        bill = tickets * 18;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                    else if (package == "Popcorn")
                    {
                        bill = tickets * 25;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                    else if (package == "Menu")
                    {
                        bill = tickets * 30;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                }
            }
            else
            {
                if (tickets == 2)
                {
                    if (package == "Drink")
                    {
                        bill = tickets * 9;
                        bill = bill * 0.85;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                    else if (package == "Popcorn")
                    {
                        bill = tickets * 11;
                        bill = bill * 0.85;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                    else if (package == "Menu")
                    {
                        bill = tickets * 14;
                        bill = bill * 0.85;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                }
                else
                {
                    if (package == "Drink")
                    {
                        bill = tickets * 9;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                    else if (package == "Popcorn")
                    {
                        bill = tickets * 11;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                    else if (package == "Menu")
                    {
                        bill = tickets * 14;
                        Console.WriteLine($"Your bill is {bill:f2} leva.");
                    }
                }
            }
        }
    }
}
