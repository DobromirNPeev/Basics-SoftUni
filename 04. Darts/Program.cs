using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string area = "";
            int points = 0;
            int sum = 0;
            int successCount=0;
            int failCount=0;
            while(sum<301)
            {
                area = Console.ReadLine();
                if (area == "Retire") break;
                points = int.Parse(Console.ReadLine());
                if (area == "Single")
                {
                    sum += points;
                    if (sum > 301)
                    {
                        sum -= points;
                        failCount++;
                    }
                    else
                    {
                        successCount++;
                    }
                }
                else if(area == "Double")
                {
                    sum += points * 2;
                    if (sum > 301) 
                    {
                        sum -= points * 2;
                        failCount++;
                    }
                    else
                    {
                        successCount++;
                    }
                }
                else if(area == "Triple")
                {
                    sum += points * 3;
                    if (sum > 301)
                    {
                        sum -= points * 3;
                        failCount++;
                    }
                    else
                    {
                        successCount++;
                    }
                }
            }
            if (sum == 301)
            {
                Console.WriteLine($"{name} won the leg with {successCount} shots.");
            }
            else if (area == "Retire")
            {
                Console.WriteLine($"{name} retired after {failCount} unsuccessful shots.");
            }
        }
    }
}
