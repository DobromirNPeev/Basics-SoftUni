using System;

namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string destination;
            string type;
            switch(season)
            {
                case "summer":
                    if(budget<=100)
                    {
                        price = budget * 0.3;
                        destination = "Bulgaria";
                            type = "Camp";
                        Console.WriteLine($"Somewhere in {destination}");
                        Console.WriteLine($"{type} - { price,0:f2}");
                    }
                    else if(budget>100 && budget <=1000)
                    {
                        price=budget* 0.4;
                        destination = "Balkans";
                        type = "Camp";
                        Console.WriteLine($"Somewhere in {destination}");
                        Console.WriteLine($"{type} - { price,0:f2}");
                    }
                    else if(budget>1000)
                    {
                        price = budget * 0.9;
                        destination = "Europe";
                        type="Hotel";
                        Console.WriteLine($"Somewhere in {destination}");
                        Console.WriteLine($"{type} - { price,0:f2}");
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        price = budget * 0.7;
                        destination = "Bulgaria";
                        type = "Hotel";
                        Console.WriteLine($"Somewhere in {destination}");
                        Console.WriteLine($"{type} - { price,0:f2}");
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        price = budget * 0.8;
                        destination = "Balkans";
                        type = "Hotel";
                        Console.WriteLine($"Somewhere in {destination}");
                        Console.WriteLine($"{type} - { price,0:f2}");
                    }
                    else if (budget > 1000)
                    {
                        price = budget * 0.9;
                        destination = "Europe";
                        type = "Hotel";
                        Console.WriteLine($"Somewhere in {destination}");
                        Console.WriteLine($"{type} - { price,0:f2}");
                    }
                    break;
            }
        }
    }
}
