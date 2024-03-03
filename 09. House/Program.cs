using System;

namespace _09._House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int rows = 1;rows <= (n + 1) / 2; rows++)
            {
                for (int colms = 1; colms <= (n + 1) / 2 - rows; colms++)
                {
                    Console.Write("-");
                }
                if (n % 2 == 0)
                {
                    Console.Write("**");
                    for (int colms = 1; colms <= rows - 1; colms++)
                    {
                        Console.Write("**");
                    }
                    for (int colms = 1; colms <= (n + 1) / 2 - rows; colms++)
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    for (int colms = 1; colms <= rows - 1; colms++)
                    {
                        Console.Write("*");
                    }
                    for (int colms = 0; colms < rows; colms++)
                    {
                        Console.Write("*");
                    }
                    for (int colms = 1; colms <= (n + 1) / 2 - rows; colms++)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i <=n/2; i++)
            {
                Console.Write("|");
                for(int j = 1; j <= n -2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("|");
            }
        }
    }
}
