using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            while (true)
            {
                string read = Console.ReadLine();
                if (read == password)
                {
                    Console.WriteLine($"Welcome {name}!");
                    break;
                }
            }
        }
    }
}
