using System;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int wantedJump = int.Parse(Console.ReadLine());
            int wantedJump1 = wantedJump - 30;
            int count = 0;
            int allCount = 0;
            bool jumped = true;
            while(wantedJump1<=wantedJump)
            {
                int jump = int.Parse(Console.ReadLine());
                if (jump > wantedJump1)
                {
                    wantedJump1 += 5;
                    count = 0;
                    allCount++;
                }
                else
                {
                    count++;
                    allCount++;
                    if (count == 3)
                    {
                        jumped = false;
                        break;
                    }
                }
            }
            if (jumped)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {wantedJump}cm after {allCount} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir failed at {wantedJump1}cm after {allCount} jumps.");
            }
        }
    }
}
