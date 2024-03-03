using System;

namespace _05._Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int adults = 0;
            int kids = 0;
            int toysMoney = 0;
            int sweatshirtMoney = 0;
            while ((input = Console.ReadLine()) != "Christmas")
            {
                int age = int.Parse(input);
                if (age <= 16)
                {
                    kids++;
                    toysMoney += 5;
                }
                else
                {
                    adults++;
                    sweatshirtMoney += 15;
                }
            }
            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {toysMoney}");
            Console.WriteLine($"Money for sweaters: {sweatshirtMoney}");
        }
    }
}
