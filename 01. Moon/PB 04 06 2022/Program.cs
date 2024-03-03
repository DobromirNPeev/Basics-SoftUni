using System;

namespace PB_04_06_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double burnedOil = double.Parse(Console.ReadLine());
            double length = 768800;
            length =Math.Ceiling(length/ speed)+3;
            Console.WriteLine(length);
            length = 768800;
            double oil = (burnedOil * length) / 100;
            Console.WriteLine(oil);
        }
    }
}
