using System;

namespace WhileLoopMoreExerciseDishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            int sum = bottles * 750;
            int sum1 = 0;
            int count = 1;
            int platesSum = 0;
            int potsSum = 0;
            string text = Console.ReadLine();
            while (text != "End" && sum1<=sum)
            {
                int num = int.Parse(text);
                int pots = 0;
                int plates = 0;
                if (count % 3 == 0)
                {
                    potsSum += num;
                    pots = num * 15;
                    sum1 += pots;
                }
                else
                {
                    platesSum += num;
                    plates = num * 5;
                    sum1 += plates;
                }
                text = Console.ReadLine();
                    count++;
            }
            if (sum1<=sum)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{platesSum} dishes and {potsSum} pots were washed.");
                Console.WriteLine($"Leftover detergent {sum-sum1} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {sum1-sum} ml. more necessary!");
            }
        }
    }
}
