using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int pieces = width * lenght;
            int num = 0;
            string text = Console.ReadLine();
             while(text!="STOP") 
            {
                num = int.Parse(text);
                pieces -= num;
                if (pieces < 0)
                {
                    break;
                }
                text = Console.ReadLine();
            }
            if (pieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
        }
    }
}
