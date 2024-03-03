using System;

namespace FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litres = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            double price = 0;
            if (fuelType == "Gas")
            {
                if (clubCard == "Yes")
                {
                    if (litres > 20 && litres <= 25)
                    {
                        price = 0.85 * litres * 0.92;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        price = 0.85 * litres * 0.9;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres <= 20)
                    {
                        price = 0.85 * litres;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (clubCard == "No")
                {
                    if (litres > 20 && litres <= 25)
                    {
                        price = 0.93 * litres * 0.92;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        price = 0.93 * litres * 0.9;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres <= 20)
                    {
                        price = 0.93 * litres;
                        Console.WriteLine($"{price:f2} lv.");
                    }

                }
            }
            else if (fuelType == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    if (litres > 20 && litres <= 25)
                    {
                        price = 2.21 * litres * 0.92;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        price = 2.21 * litres * 0.9;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres <= 20)
                    {
                        price = 2.21 * litres;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (clubCard == "No")
                {
                    if (litres > 20 && litres <= 25)
                    {
                        price = 2.33 * litres * 0.92;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        price = 2.33 * litres * 0.9;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres <= 20)
                    {
                        price = 2.33 * litres;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
            }
            else if (fuelType == "Gasoline")
            {
                if (clubCard == "Yes")
                {
                    if (litres > 20 && litres <= 25)
                    {
                        price = 2.04 * litres * 0.92;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        price = 2.04 * litres * 0.9;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres <= 20)
                    {
                        price = 2.04 * litres;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (clubCard == "No")
                {
                    if (litres > 20 && litres <= 25)
                    {
                        price = 2.22 * litres * 0.92;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        price = 2.22 * litres * 0.9;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (litres <= 20)
                    {
                        price = 2.22 * litres;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
            }
        }
    }
}
