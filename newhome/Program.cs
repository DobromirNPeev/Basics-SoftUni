using System;

namespace newhome
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price =0;
            double finalPrice = 0;
            switch(type)
            {
                case "Roses":
                    if(num>80)
                    {
                        price = num * 5 * 0.9;
                        if(price>budget)
                        {
                            finalPrice = price - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.",finalPrice);
                        }
                        else
                        {
                            finalPrice = budget-price;
                            Console.WriteLine($"Hey, you have a great garden with {num} {type} and {finalPrice,0:f2} leva left.");
                        }
                    }
                    else
                    {
                        price = num * 5;
                        if (price > budget)
                        {
                            finalPrice = price - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.",finalPrice);
                        }
                        else
                        {
                            finalPrice = budget-price;
                            Console.WriteLine($"Hey, you have a great garden with {num} {type} and {finalPrice,0:f2} leva left.");
                        }
                    }
                    break;
                case "Dahlias":
                    if (num > 90)
                    {
                        price = num * 3.8 * 0.85;
                        if (price > budget)
                        {
                            finalPrice = price - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", finalPrice);
                        }
                        else
                        {
                            finalPrice = budget - price;
                            Console.WriteLine($"Hey, you have a great garden with {num} {type} and {finalPrice,0:f2} leva left.");
                        }
                    }
                    else
                    {
                        price = num * 3.8;
                        if (price > budget)
                        {
                            finalPrice = price - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", finalPrice);
                        }
                        else
                        {
                            finalPrice = budget - price;
                            Console.WriteLine($"Hey, you have a great garden with {num} {type} and {finalPrice,0:f2} leva left.");
                        }
                    }
                    break;
                case "Tulips":
                    if (num > 80)
                    {
                        price = num * 2.80 * 0.85;
                        if (price > budget)
                        {
                            finalPrice = price - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", finalPrice);
                        }
                        else
                        {
                            finalPrice = budget - price;
                            Console.WriteLine($"Hey, you have a great garden with {num} {type} and {finalPrice,0:f2} leva left.");
                        }
                    }
                    else
                    {
                        price = num * 2.80;
                        if (price > budget)
                        {
                            finalPrice = price - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", finalPrice);
                        }
                        else
                        {
                            finalPrice = budget - price;
                            Console.WriteLine($"Hey, you have a great garden with {num} {type} and {finalPrice,0:f2} leva left.");
                        }
                    }
                    break;
                case "Narcissus":
                    if (num < 120)
                    {
                        price = num * 3;
                        price = price + price * 0.15;
                        if (price > budget)
                        {
                            finalPrice = price - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", finalPrice);
                        }
                        else
                        {
                            finalPrice = budget - price;
                            Console.WriteLine($"Hey, you have a great garden with {num} {type} and {finalPrice,0:f2} leva left.");
                        }
                    }
                    else
                    {
                        price = num * 3;
                        if (price > budget)
                        {
                            finalPrice = price - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", finalPrice);
                        }
                        else
                        {
                            finalPrice = budget - price;
                            Console.WriteLine($"Hey, you have a great garden with {num} {type} and {finalPrice,0:f2} leva left.");
                        }
                    }
                    break;
                case "Gladiolus":
                    if (num < 80)
                    {
                        price =num * 2.5;
                        price = price + price * 0.2;
                        if (price > budget)
                        {
                            finalPrice = price - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", finalPrice);
                        }
                        else
                        {
                            finalPrice = budget - price;
                            Console.WriteLine($"Hey, you have a great garden with {num} {type} and {finalPrice,0:f2} leva left.");
                        }
                    }
                    else
                    {
                        price = num * 2.5;
                        if (price > budget)
                        {
                            finalPrice = price - budget;
                            Console.WriteLine("Not enough money, you need {0:f2} leva more.", finalPrice);
                        }
                        else
                        {
                            finalPrice = budget - price;
                            Console.WriteLine($"Hey, you have a great garden with {num} {type} and {finalPrice,0:f2} leva left.");
                        }
                    }
                    break;
            }
        }
    }
}
