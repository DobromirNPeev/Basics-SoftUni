using System;

namespace _02._Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            int secondsFor100m = int.Parse(Console.ReadLine());
            int control = minutes * 60 + seconds;
            double leftTime = lenght / 120;
            leftTime = leftTime * 2.5;
            double MarinTime = (lenght / 100) * secondsFor100m - leftTime;
            if (MarinTime <= control)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {MarinTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {MarinTime-control:f3} second slower.");
            }
        }
    }
}
