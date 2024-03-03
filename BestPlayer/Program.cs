using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            string name = "";
            string bestplayer = "";
            int goals = 0;
            while (name != "END")
            {
               name = Console.ReadLine();
                if (name == "END") break;
                goals = int.Parse(Console.ReadLine());
                if (goals > max)
                {
                    max = goals;
                    bestplayer = name;
                }
                if (goals >= 10) break;
            }
            if (goals >= 3)
            {
                Console.WriteLine($"{bestplayer} is the best player!");
                Console.WriteLine($"He has scored {max} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{bestplayer} is the best player!");
                Console.WriteLine($"He has scored {max} goals.");
            }
        }
    }
}
