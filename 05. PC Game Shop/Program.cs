using System;

namespace _05._PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double hearthstoneCount = 0;
            double fortniteCount = 0;
            double overwatchCount = 0;
            double othersCount = 0;
            for (int i = 1; i <= n; i++)
            {
                string game = Console.ReadLine();
                if(game== "Hearthstone")
                {
                    hearthstoneCount++;
                }
                else if(game== "Fornite")
                {
                    fortniteCount++;
                }
                else if(game== "Overwatch")
                {
                    overwatchCount++;
                }
                else
                {
                    othersCount++;
                }
            }
            Console.WriteLine($"Hearthstone - {hearthstoneCount/n*100:f2}%");
            Console.WriteLine($"Fornite - {fortniteCount/n*100:f2}%");
            Console.WriteLine($"Overwatch - {overwatchCount/n*100:f2}%");
            Console.WriteLine($"Others - {othersCount/n*100:f2}%");
        }
    }
}
