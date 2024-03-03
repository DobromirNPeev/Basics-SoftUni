using System;

namespace Programming_Basics_Online_Exam___15_and_16_June_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            int durationWithoutCommercial = int.Parse(Console.ReadLine());
            double duration = durationWithoutCommercial * 1.20;
            int addedTime = seasons * 10;
            double sum = (duration * episodes * seasons) + addedTime;
            Console.WriteLine($"Total time needed to watch the {series} series is {sum} minutes.");
        }
    }
}
