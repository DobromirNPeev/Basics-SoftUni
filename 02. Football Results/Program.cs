using System;

namespace _02._Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstMatch =Console.ReadLine();
            string secondMatch = Console.ReadLine();
            string thirdMatch = Console.ReadLine();
            int HomeTeam = firstMatch[0];
            int AwayTeam = firstMatch[2];
            int winCount = 0;
            int loseCount = 0;
            int drawCount = 0;
            if (HomeTeam > AwayTeam)
            {
                winCount++;
            }
            else if (HomeTeam == AwayTeam)
            {
                drawCount++;
            }
            else
            {
                loseCount++;
            }
            HomeTeam = secondMatch[0];
            AwayTeam = secondMatch[2];
            if (HomeTeam > AwayTeam)
            {
                winCount++;
            }
            else if (HomeTeam == AwayTeam)
            {
                drawCount++;
            }
            else
            {
                loseCount++;
            }
            HomeTeam = thirdMatch[0];
            AwayTeam = thirdMatch[2];
            if (HomeTeam > AwayTeam)
            {
                winCount++;
            }
            else if (HomeTeam == AwayTeam)
            {
                drawCount++;
            }
            else
            {
                loseCount++;
            }
            Console.WriteLine($"Team won {winCount} games.");
            Console.WriteLine($"Team lost {loseCount} games.");
            Console.WriteLine($" Drawn games: {drawCount}");
        }
    }
}
