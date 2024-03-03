using System;

namespace zoomag
{
    class Program
    {
        static void Main(string[] args)
        {
            double kotki = double.Parse(Console.ReadLine());
            kotki =kotki * 2.5;
            double kucheta = double.Parse(Console.ReadLine());
            kucheta =kucheta * 4;
            double sum = kotki + kucheta;
            Console.WriteLine($"{sum} lv.");
        }
    }
}
