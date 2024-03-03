using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string raceType = Console.ReadLine();
            if (raceType == "trail")
            {
                double juniorSum = juniors * 5.50;
                double seniorSum = seniors * 7;
                double sum = (juniorSum + seniorSum) * 0.95;
                Console.WriteLine($"{sum:f2}");
            }
            else if (raceType == "cross-country")
            {
                if (juniors + seniors>=50)
                {
                    double juniorSum = juniors * (8-(8*0.25));
                    double seniorSum = seniors * (9.50-(9.50*0.25));
                    double sum = (juniorSum + seniorSum) * 0.95;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    double juniorSum = juniors * 8;
                    double seniorSum = seniors * 9.50;
                    double sum = (juniorSum + seniorSum) * 0.95;
                    Console.WriteLine($"{sum:f2}");
                }
            }
            else if(raceType=="downhill")
            {
                double juniorSum = juniors * 12.25;
                double seniorSum = seniors * 13.75;
                double sum = (juniorSum + seniorSum) * 0.95;
                Console.WriteLine($"{sum:f2}");
            }
            else if(raceType=="road")
            {
                double juniorSum = juniors * 20;
                double seniorSum = seniors * 21.50;
                double sum = (juniorSum + seniorSum) * 0.95;
                Console.WriteLine($"{sum:f2}");
            }
        }
    }
}
