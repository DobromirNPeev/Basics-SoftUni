using System;

namespace perimeterandcirlearea
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = r * r * Math.PI;
            double parameter = 2 * r * Math.PI;
            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{parameter:f2}");
        }
    }
}
