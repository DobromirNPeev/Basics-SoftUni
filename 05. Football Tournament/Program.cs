using System;

namespace _05._Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int matches = int.Parse(Console.ReadLine());
            double Wcount = 0;
            int Lcount = 0;
            int Dcount = 0;
            int sum = 0;
            if (matches == 0)
            {
                Console.WriteLine($"{name} hasn't played any games during this season.");
            }
            else
            {
                for (int i = 1; i <= matches; i++)
                {
                    string typeOfMatch = Console.ReadLine();
                    if (typeOfMatch == "W")
                    {
                        sum += 3;
                        Wcount++;
                    }
                    else if(typeOfMatch == "D")
                    {
                        sum += 1;
                        Dcount++;
                    }
                    else if (typeOfMatch == "L")
                    {
                        Lcount++;
                    }
                }
                Console.WriteLine($"{name} has won {sum} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {Wcount}");
                Console.WriteLine($"## D: {Dcount}");
                Console.WriteLine($"## L: {Lcount}");
                Console.WriteLine($"Win rate: {Wcount/matches*100:f2}%");
            }
        }
    }
}
