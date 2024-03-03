using System;

namespace _12._The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int count=0;
            int a1 = 0;
            int b1 = 0;
            int c1 = 0;
            int d1 = 0;
            bool isFound = false;
            for(int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <=9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d==M && a<b && c>d)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                count++;
                                if (count == 4)
                                {
                                    a1 = a;
                                    b1 = b;
                                    c1 = c;
                                    d1 = d;
                                    isFound = true;
                                }
                            }
                        }
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine();
                Console.Write($"Password: {a1}{b1}{c1}{d1}");
            }
            else
            {
                Console.WriteLine();
                Console.Write("No!");
            }
        }
    }
}
