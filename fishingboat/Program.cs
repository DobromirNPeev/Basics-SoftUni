using System;

namespace fishingboat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double price = 0;
            switch(season)
            {
                case "Spring":
                    if(num<=6 && num%2==0)
                    {
                        price = 3000 * 0.90*0.95;
                        if(price>budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price-budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget-price,0:f2} leva left.");
                        }
                    }
                    else if (num <= 6 && num%2==1)
                    {
                        price = 3000 * 0.90;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if(num>=7 && num<=11 && num%2==0)
                    {
                        price = 3000 * 0.85*0.95;
                            if(price>budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if(num>=7 && num<=11 && num%2==1)
                    {
                        price = 3000 * 0.85;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if(num>=12 && num%2==0)
                    {
                        price = 3000 * 0.75*0.95;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if(num>=12 && num%2==1)
                    {
                        price = 3000 * 0.75;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    break;
                case "Summer":
                    if (num <= 6 && num % 2 == 0)
                    {
                        price = 4200 * 0.90*0.95;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num <= 6 && num%2==1)
                    {
                        price = 4200 * 0.90;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num >= 7 && num <= 11 && num % 2 == 0)
                    {
                        price = 4200 * 0.85*0.95;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num >= 7 && num <= 11 && num%2==1)
                    {
                        price = 4200 * 0.85;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num >= 12 && num % 2 == 0)
                    {
                        price = 4200 * 0.75*0.95;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num >= 12 && num%2==1)
                    {
                        price = 4200 * 0.75;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    break;
                case "Winter":
                    if (num <= 6 && num % 2 == 0)
                    {
                        price = 2600 * 0.90*0.95;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num <= 6 && num%2==1)
                    {
                        price = 2600 * 0.90;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num >= 7 && num <= 11 && num % 2 == 0)
                    {
                        price = 2600 * 0.85*0.95;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num >= 7 && num <= 11 && num%2==1)
                    {
                        price = 2600 * 0.85;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num >= 12 && num % 2 == 0)
                    {
                        price = 2600 * 0.75*0.95;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num >= 12 && num%2==1)
                    {
                        price = 2600 * 0.75;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else if (price <= budget)
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    break;
                case "Autumn":
                    if (num <= 6)
                    {
                        price = 4200 * 0.90;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num >= 7 && num <= 11)
                    {
                        price = 4200 * 0.85;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    else if (num >= 12)
                    {
                        price = 4200 * 0.75;
                        if (price > budget)
                        {
                            Console.WriteLine($"Not enough money! You need {price - budget,0:f2} leva.");
                        }
                        else
                        {
                            Console.WriteLine($"Yes! You have {budget - price,0:f2} leva left.");
                        }
                    }
                    break;
            }
        }
    }
}
