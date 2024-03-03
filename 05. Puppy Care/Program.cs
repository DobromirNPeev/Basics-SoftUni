using System;

namespace _05._Puppy_Care
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            food = food * 1000;
            string text = Console.ReadLine();
            int sum = 0;
            while (text != "Adopted")
            {
                int food1 =int.Parse(text);
                sum += food1;
                text = Console.ReadLine();
            }
            if (sum <= food)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food-sum} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {sum-food} grams more.");
            }
        }
    }
}
