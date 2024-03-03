using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum = 0;
            while (text != "Going home")
            {
                int kmWalked = int.Parse(text);
                sum += kmWalked;
                if (sum >= 10000) break;
                text = Console.ReadLine();
            }
            if (text == "Going home")
            {
                text = Console.ReadLine();
                int kmWalked1 = int.Parse(text);
                sum += kmWalked1;
            }
            if (sum>=10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sum-10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000-sum} more steps to reach goal.");
            }
        }
    }
}
