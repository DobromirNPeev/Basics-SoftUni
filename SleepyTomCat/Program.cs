using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int daysOn = 365 - daysOff;
            int playingTime = (daysOff * 127) + (daysOn * 63);
            if(30000>=playingTime)
            {
                Console.WriteLine("Tom sleeps well");
                int H = (30000 - playingTime) / 60;
                int M = (30000 - playingTime) % 60;
                Console.WriteLine($"{H} hours and {M} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                int H = (playingTime-30000) / 60;
                int M = (playingTime - 30000) % 60;
                Console.WriteLine($"{H} hours and {M} minutes more for play");
            }
        }
    }
}
