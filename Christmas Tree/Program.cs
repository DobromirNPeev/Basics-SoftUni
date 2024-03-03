using System;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n ; rows++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(" |");
            for (int rows = 1; rows <= n; rows++)
            {
                for (int colms = 1; colms <= n - rows; colms++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int colms = 1; colms <= rows - 1; colms++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int colms = 0; colms < rows; colms++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
