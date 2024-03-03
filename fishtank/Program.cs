using System;

namespace fishtank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            percent = percent / 100;
            double volume = (length * width * height)/1000;
            double outcome = volume - (volume * percent);
            Console.WriteLine(outcome); ;
        }
    }
}
