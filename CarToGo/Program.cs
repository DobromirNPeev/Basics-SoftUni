using System;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            if (season == "Summer")
            {
                if (budget <= 100)
                {
                    Console.WriteLine("Economy class");
                    price = 0.35 * budget;
                    Console.WriteLine($"Cabrio - {price:f2}");
                }
                else if( budget>100 && budget<=500)
                {
                    Console.WriteLine("Compact class");
                    price = 0.45 * budget;
                    Console.WriteLine($"Cabrio - {price:f2}");
                }
                else if (budget > 500)
                {
                    Console.WriteLine("Luxury class");
                    price = 0.9 * budget;
                    Console.WriteLine($"Jeep - {price:f2}");
                }
            }
            else if (season == "Winter")
            {
                if (budget <= 100)
                {
                    Console.WriteLine("Economy class");
                    price = 0.65 * budget;
                    Console.WriteLine($"Jeep - {price:f2}");
                }
                else if (budget > 100 && budget <= 500)
                {
                    Console.WriteLine("Compact class");
                    price = 0.8 * budget;
                    Console.WriteLine($"Jeep - {price:f2}");
                }
                else if (budget > 500)
                {
                    Console.WriteLine("Luxury class");
                    price = 0.9 * budget;
                    Console.WriteLine($"Jeep - {price:f2}");
                }
            }
        }
    }
}
