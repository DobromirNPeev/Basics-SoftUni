using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location;
            double price = 0;
            if (season == "Summer")
            {
                if(budget<=1000)
                {
                    location = "Camp";
                    price = 0.65 * budget;
                    Console.WriteLine($"Alaska - {location} - {price:f2}");
                }
                else if(budget>1000 && budget <= 3000)
                {
                    location = "Hut";
                    price = 0.8 * budget;
                    Console.WriteLine($"Alaska - {location} - {price:f2}");
                }
                else if (budget > 3000)
                {
                    location = "Hotel";
                    price = 0.9 * budget;
                    Console.WriteLine($"Alaska - {location} - {price:f2}");
                }
            }
            else if (season == "Winter")
            {
                if (budget <= 1000)
                {
                    location = "Camp";
                    price = 0.45 * budget;
                    Console.WriteLine($"Morocco - {location} - {price:f2}");
                }
                else if (budget > 1000 && budget <= 3000)
                {
                    location = "Hut";
                    price = 0.6 * budget;
                    Console.WriteLine($"Morocco - {location} - {price:f2}");
                }
                else if (budget > 3000)
                {
                    location = "Hotel";
                    price = 0.9 * budget;
                    Console.WriteLine($"Morocco - {location} - {price:f2}");
                }                             
            }
        }
    }
}
