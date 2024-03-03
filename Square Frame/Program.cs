using System;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write("+ ");
                    for (int j = i + 1; j <= n - 1; j++)
                    {
                        Console.Write("- ");
                    }
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                int variable = 0;
                if(i>1 && i < n)
                {
                    Console.Write("| ");
                    for (int j = variable + 1; j <= n - 2; j++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("|");
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write("+ ");
                    for (int j = i + 1; j <= n - 1; j++)
                    {
                        Console.Write("- ");
                    }
                }
            }
        }
    }
}
