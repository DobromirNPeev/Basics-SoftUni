using System;

namespace lunchbreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            double runtime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());
            double lunchTime =  0.125 * breakTime;
            double chillTime = 0.25 * breakTime;
            double timeToWatch = breakTime - lunchTime - chillTime;
            if(runtime<=timeToWatch)
            {
                timeToWatch = timeToWatch - runtime;
                timeToWatch= Math.Ceiling(timeToWatch);
                Console.WriteLine($"You have enough time to watch {series} and left with {timeToWatch} minutes free time.");
            }
            else if(runtime>timeToWatch)
            {
                runtime = runtime - timeToWatch;
                runtime =Math.Ceiling(runtime);
                Console.WriteLine($"You don't have enough time to watch {series}, you need {runtime} more minutes.");
            }
        }
    }
}
