using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            int sumFlowers = chrysanthemums + roses + tulips;
            if (season == "Spring")
            {
                double chrysanthemumPrice = chrysanthemums * 2;
                double rosePrice = roses * 4.1;
                double tulipPrice = tulips * 2.5;
                double sum = chrysanthemumPrice + rosePrice + tulipPrice;
                if (holiday == "Y")
                {
                    sum = 1.15 * sum;
                    if (tulips > 7)
                    {
                        sum = sum * 0.95;
                        if (sumFlowers > 20)
                        {
                            sum = sum * 0.8;
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                    }
                    else
                    {
                        if (sumFlowers > 20)
                        {
                            sum = sum * 0.8;
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                    }
                }
                else if (holiday == "N")
                {
                    if (tulips > 7)
                    {
                        sum = sum * 0.95;
                        if (sumFlowers > 20)
                        {
                            sum = sum * 0.8;
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                    }
                    else
                    {
                        if (sumFlowers > 20)
                        {
                            sum = sum * 0.8;
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                    }
                }
            } 
            else if(season=="Summer")
            {
                double chrysanthemumPrice = chrysanthemums * 2;
                double rosePrice = roses * 4.1;
                double tulipPrice = tulips * 2.5;
                double sum = chrysanthemumPrice + rosePrice + tulipPrice;
                if (holiday == "Y")
                {
                    sum = 1.15 * sum;
                    if (sumFlowers > 20)
                    {
                        sum = sum * 0.8;
                        Console.WriteLine($"{sum + 2:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{sum + 2:f2}");
                    }
                }
                else if (holiday == "N")
                {
                    if (sumFlowers > 20)
                    {
                        sum = sum * 0.8;
                        Console.WriteLine($"{sum + 2:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{sum + 2:f2}");
                    }
                }
            }
            else if (season == "Autumn")
            {
                double chrysanthemumPrice = chrysanthemums * 3.75;
                double rosePrice = roses * 4.5;
                double tulipPrice = tulips * 4.15;
                double sum = chrysanthemumPrice + rosePrice + tulipPrice;
                if (holiday == "Y")
                {
                    sum = 1.15 * sum;
                    if (sumFlowers > 20)
                    {
                        sum = sum * 0.8;
                        Console.WriteLine($"{sum + 2:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{sum + 2:f2}");
                    }
                }
                else if (holiday == "N")
                {
                    if (sumFlowers > 20)
                    {
                        sum = sum * 0.8;
                        Console.WriteLine($"{sum + 2:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{sum + 2:f2}");
                    }
                }
            }
            else if (season == "Winter")
            {
                double chrysanthemumPrice = chrysanthemums * 3.75;
                double rosePrice = roses * 4.5;
                double tulipPrice = tulips * 4.15;
                double sum = chrysanthemumPrice + rosePrice + tulipPrice;
                if (holiday == "Y")
                {
                    sum = 1.15 * sum;
                    if (roses >= 10)
                    {
                        sum = sum * 0.90;
                        if (sumFlowers > 20)
                        {
                            sum = sum * 0.8;
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                    }
                    else
                    {
                        if (sumFlowers > 20)
                        {
                            sum = sum * 0.8;
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                    }
                }
                else if (holiday == "N")
                {
                    if (roses>= 10)
                    {
                        sum = sum * 0.90;
                        if (sumFlowers > 20)
                        {
                            sum = sum * 0.8;
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                    }
                    else
                    {
                        if (sumFlowers > 20)
                        {
                            sum = sum * 0.8;
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sum + 2:f2}");
                        }
                    }
                }
            }
        }
    }
}
