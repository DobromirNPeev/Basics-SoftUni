using System;

namespace _04._Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();
            int player1Points = 0;
            int player2Points = 0;
            string winner = "";
            int winnerPoints = 0;
            while (true)
            {
                string player1card = Console.ReadLine();
                if(player1card=="End of game")
                {
                    Console.WriteLine($"{player1} has {player1Points} points");
                    Console.WriteLine($"{player2} has {player2Points} points");
                    break;
                }
                int player1card1 = int.Parse(player1card);
                int player2card = int.Parse(Console.ReadLine());
                if (player1card1 > player2card)
                {
                    player1card1 -= player2card;
                    player1Points += player1card1;
                }
                else if(player1card1 < player2card)
                {
                    player2card -= player1card1;
                    player2Points += player2card;
                }
                else
                {
                    player1card1 = int.Parse(Console.ReadLine());
                    player2card = int.Parse(Console.ReadLine());
                    if (player1card1 > player2card)
                    {
                        winner = player1;
                        winnerPoints = player1Points;
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{winner} is winner with {winnerPoints} points");
                    }
                    else if (player2card > player1card1)
                    {
                        winner = player2;
                        winnerPoints = player2Points;
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{winner} is winner with {winnerPoints} points");
                    }
                    break;
                }
            }
        }
    }
}
