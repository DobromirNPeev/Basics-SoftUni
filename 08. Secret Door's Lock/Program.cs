using System;

namespace Nested_Loops___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 2; j <= m; j++)
                    {
                        if (j != 4 && j != 6 && j <= 7)
                        {
                            for (int k = 2; k <= p; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    Console.Write($"{i} {j} {k}");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
