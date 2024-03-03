using System;

namespace _03._Pastry_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string pastry = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            double price = 0;
            if (day <= 15)
            {
                if (pastry == "Cake")
                {
                    price = 24 * num;
                }
                else if (pastry == "Souffle")
                {
                    price = 6.66 * num;
                }
                else
                {
                    price = 12.6 * num;
                }
            }
            else
            {
                if (pastry == "Cake")
                {
                    price = 28.7 * num;
                }
                else if (pastry == "Souffle")
                {
                    price = 9.8 * num;
                }
                else
                {
                    price = 16.98 * num;
                }
            }
            if (day <= 22)
            {
                if(price>=100 && price <= 200)
                {
                    price *= 0.85;
                }
                else if (price > 200)
                {
                    price *= 0.75;
                }
                if (day <= 15)
                {
                    price = price * 0.9;
                }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
