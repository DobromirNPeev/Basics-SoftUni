using System;

namespace summeroutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            switch (time)
            {
                case "Morning":
                    if (degree >= 10 && degree <= 18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Sweatshirt and Sneakers.");
                    }
                    if (degree > 18 && degree <= 24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    if (degree >= 25)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your T-Shirt and Sandals.");
                    }
                    break;
                case "Afternoon":
                    if (degree >= 10 && degree <= 18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    if (degree > 18 && degree <= 24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your T-Shirt and Sandals.");
                    }
                    if (degree >= 25)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Swim Suit and Barefoot.");
                    }
                    break;
                case "Evening":
                    if (degree >= 10 && degree <= 18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    if (degree > 18 && degree <= 24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    if (degree >= 25)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your Shirt and Moccasins.");
                    }
                    break;
            }
        }
    }
}
