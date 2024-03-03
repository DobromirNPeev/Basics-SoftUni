using System;

namespace _02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForShooting = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int duration = int.Parse(Console.ReadLine());
            double preparation = timeForShooting * 0.15;
            double sum = (scenes * duration) + preparation;
            if (sum > timeForShooting)
            {
                Console.WriteLine($"Time is up! To complete the movie you need {sum-timeForShooting} minutes.");
            }
            else
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForShooting - sum)} minutes left!");
            }
        }
    }
}
