using System;

namespace _01._Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double oscars = 0.7 * rent;
            double catering = 0.85 * oscars;
            double sound = 0.5* catering;
            double sum = rent + oscars + catering + sound;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
