using System;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                for (int colms = 1; colms <= n-rows; colms++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int colms = 1; colms <= rows-1; colms++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int rows = 1; rows <= n-1; rows++)
            {

                for (int colms = n; colms > n-rows; colms--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int colms = n-1; colms > rows; colms--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
