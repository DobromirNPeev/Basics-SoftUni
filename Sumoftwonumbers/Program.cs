using System;

namespace Sumoftwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int finalNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isFound = false;
            for (int i = startingNum; i <= finalNum; i++)
            {
                for (int j = startingNum; j <= finalNum; j++)
                {
                    combinations++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNum})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                    break;
            }
            if (isFound == false)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
