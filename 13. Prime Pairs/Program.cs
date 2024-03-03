using System;

namespace _13._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstStart = int.Parse(Console.ReadLine());
            int secondStart = int.Parse(Console.ReadLine());
            int firstDiff = int.Parse(Console.ReadLine());
            int secondDiff = int.Parse(Console.ReadLine());
            bool isPrime = true;
            bool isPrime1 = true;
            for (int i = firstStart; i <= firstStart+firstDiff; i++)
            {
                isPrime = true;
                for (int j = 2; j <i ; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                for (int k = secondStart; k <= secondStart+ secondDiff; k++)
                {
                    isPrime1 = true;
                    for (int u = 2; u < k; u++)
                    {
                        if (k % u == 0)
                        {
                            isPrime1 = false;
                            break;
                        }
                    }
                    if (isPrime && isPrime1)
                    {
                        Console.WriteLine($"{i}{k}");
                    }
                }
            }
        }
    }
}
