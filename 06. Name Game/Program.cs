using System;

namespace _06._Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string winner = "";
            string name = Console.ReadLine();
            int max = int.MinValue;
            while (name!="Stop")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int points = int.Parse(Console.ReadLine());
                    char letter = name[i];
                    int ascii = letter;
                    if (ascii == points)
                    {
                        sum += 10;
                    }
                    else
                    {
                        sum += 2;
                    }
                }
                if (sum >= max)
                {
                    max=sum;
                    winner = name;
                }
                name = Console.ReadLine();
                sum = 0;
            }
            Console.WriteLine($"The winner is {winner} with {max} points!");
        }
    }
}
