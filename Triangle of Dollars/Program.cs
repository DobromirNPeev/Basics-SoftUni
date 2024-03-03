using System;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int rows = 0; rows < n; rows++)
            {
                for (int colms = 0; colms < rows; colms++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine("$");
            }
        }
    }
}
