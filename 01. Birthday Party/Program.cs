using System;

namespace _01._Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double cake = 0.2 * rent;
            double drinks = 0.55 * cake;
            double animator = rent/3;
            double budget = rent + cake + drinks + animator;
            Console.WriteLine(budget);
        }
    }
}
