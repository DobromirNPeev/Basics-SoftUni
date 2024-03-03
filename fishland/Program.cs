using System;

namespace fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            int musselsKg = int.Parse(Console.ReadLine());
            double bonitoPrice = 0.6 * mackerelPrice + mackerelPrice;
            double scadPrice = 0.8 * spratPrice + spratPrice;
            double musslesSum = 7.5 * musselsKg;
            double bonitoSum = bonitoPrice * bonitoKg;
            double scadSum = scadPrice * scadKg;
            Console.WriteLine($"{musslesSum + bonitoSum + scadSum:f2}");
        }
    }
}
