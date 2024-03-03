using System;

namespace uprjif
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int sum=((hours*60)+15+min)
            double resulthour = sum / 60;
            if (resulthour >= 24)
            {
                resulthour -= 24;
            }
            double resultmin = sum % 60;

            Console.WriteLine("{0}:{1:00}", resulthour, resultmin);

        }
    }
}
