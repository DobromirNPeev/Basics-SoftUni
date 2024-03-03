using System;

namespace _02._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());
            double rocketVolume = width * length * height;
            double roomVolume = (averageHeight + 0.4) * 2 * 2;
            double roomsPerAstro =Math.Floor(rocketVolume / roomVolume);
            if (roomsPerAstro < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (roomsPerAstro > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {roomsPerAstro} astronauts.");
            }
        }
    }
}
