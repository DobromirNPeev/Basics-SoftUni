using System;

namespace housepainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double frontWall = (x * x)-2.4;
            double backWall = x * x;
            double wall = (x * y) - 2.25;
            double rooftop = x * y;
            double roofTriangle = x * h / 2;
            double sumGreen = (frontWall + backWall + 2 * wall) / 3.4;
            double sumRed = (2 * rooftop + 2 * roofTriangle) / 4.3;
            Console.WriteLine($"{sumGreen:f2}");
            Console.WriteLine($"{sumRed:f2}");

        }
    }
}
