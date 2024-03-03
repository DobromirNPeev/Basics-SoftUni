using System;

namespace _06._Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournament = Console.ReadLine();
            double winCount = 0;
            int sum = 0;
            double loseCount = 0;
            while(tournament!= "End of tournaments")
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    int desiTeam = int.Parse(Console.ReadLine());
                    int enemyTeam = int.Parse(Console.ReadLine());
                    if (desiTeam > enemyTeam)
                    {
                        Console.WriteLine($"Game {i} of tournament {tournament}: win with {desiTeam-enemyTeam} points.");
                        winCount++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {tournament}: lost with {enemyTeam-desiTeam} points.");
                        loseCount++;
                    }
                }
                sum += n;
                tournament = Console.ReadLine();
            }
            Console.WriteLine($"{winCount/sum*100:f2}% matches win");
            Console.WriteLine($"{loseCount/sum*100:f2}% matches lost");
        }
    }
}
