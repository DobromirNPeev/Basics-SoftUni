using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int variable = 0;
                if (i == 1 || i == n)
                {
                    for (int j = 1; j <= n * 2; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= n * 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else if (i > 1 && i < n)
                {
                    Console.Write("*");
                    for (int j = variable + 1; j <= (n * 2) - 2; j++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    for (int k = 0; k < n; k++)
                    {
                        if (i == n / 2 && n%2==0)
                        {
                            Console.Write("|");
                        } 
                        else if(i == (n / 2)+1 && n % 2 ==1)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("*");
                    for (int j = variable + 1; j <= (n * 2) - 2; j++)
                    {
                        Console.Write("/");
                    }
                    Console.WriteLine("*");
                }
            }
        }
    }
}
