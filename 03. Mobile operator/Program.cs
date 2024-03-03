using System;

namespace _03._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string length = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double price = 0;
            double sum = 0;
            if (length == "one")
            {
                if (type == "Small")
                {
                    price = 9.98;
                    if (internet == "yes")
                    {
                        if (price <= 10)
                        {
                            price += 5.50;
                        }
                        else if (price > 10 && price <= 30)
                        {
                            price += 4.35;
                        }
                        else if (price > 30)
                        {
                            price += 3.85;
                        }
                        sum = months * price;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                    else
                    {
                        sum = months * price;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                }
                else if(type == "Middle")
                {
                    price = 18.99;
                    if (internet == "yes")
                    {
                        if (price <= 10)
                        {
                            price += 5.50;
                        }
                        else if (price > 10 && price <= 30)
                        {
                            price += 4.35;
                        }
                        else if (price > 30)
                        {
                            price += 3.85;
                        }
                        sum = months * price;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                    else
                    {
                        sum = months * price;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                }
                else if (type == "Large")
                {
                    price = 25.98;
                    if (internet == "yes")
                    {
                        if (price <= 10)
                        {
                            price += 5.50;
                        }
                        else if (price > 10 && price <= 30)
                        {
                            price += 4.35;
                        }
                        else if (price > 30)
                        {
                            price += 3.85;
                        }
                        sum = months * price;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                    else
                    {
                        sum = months * price;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                }
                else if (type == "ExtraLarge")
                {
                    price = 35.99;
                    if (internet == "yes")
                    {
                        if (price <= 10)
                        {
                            price += 5.50;
                        }
                        else if (price > 10 && price <= 30)
                        {
                            price += 4.35;
                        }
                        else if (price > 30)
                        {
                            price += 3.85;
                        }
                        sum = months * price;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                    else
                    {
                        sum = months * price;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                }
            }
            else
            {
                if (type == "Small")
                {
                    price = 8.58;
                    if (internet == "yes")
                    {
                        if (price <= 10)
                        {
                            price += 5.50;
                        }
                        else if (price > 10 && price <= 30)
                        {
                            price += 4.35;
                        }
                        else if (price > 30)
                        {
                            price += 3.85;
                        }
                        sum = months * price;
                        sum = sum * 0.9625;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                    else
                    {
                        sum = months * price;
                        sum = sum * 0.9625;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                }
                else if (type == "Middle")
                {
                    price = 17.09;
                    if (internet == "yes")
                    {
                        if (price <= 10)
                        {
                            price += 5.50;
                        }
                        else if (price > 10 && price <= 30)
                        {
                            price += 4.35;
                        }
                        else if (price > 30)
                        {
                            price += 3.85;
                        }
                        sum = months * price;
                        sum = sum * 0.9625;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                    else
                    {
                        sum = months * price;
                        sum = sum * 0.9625;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                }
                else if (type == "Large")
                {
                    price = 23.59;
                    if (internet == "yes")
                    {
                        if (price <= 10)
                        {
                            price += 5.50;
                        }
                        else if (price > 10 && price <= 30)
                        {
                            price += 4.35;
                        }
                        else if (price > 30)
                        {
                            price += 3.85;
                        }
                        sum = months * price;
                        sum = sum * 0.9625;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                    else
                    {
                        sum = months * price;
                        sum = sum * 0.9625;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                }
                else if (type == "ExtraLarge")
                {
                    price = 31.79;
                    if (internet == "yes")
                    {
                        if (price <= 10)
                        {
                            price += 5.50;
                        }
                        else if (price > 10 && price <= 30)
                        {
                            price += 4.35;
                        }
                        else if (price > 30)
                        {
                            price += 3.85;
                        }
                        sum = months * price;
                        sum = sum * 0.9625;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                    else
                    {
                        sum = months * price;
                        sum = sum * 0.9625;
                        Console.WriteLine($"{sum:f2} lv.");
                    }
                }
            }
        }
    }
}
