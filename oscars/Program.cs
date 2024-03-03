using System;

namespace oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nominee = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double result = 0;
                for(int i=1;i<=n;i++)
            {
                string name = Console.ReadLine();
                double pointsByName = double.Parse(Console.ReadLine());
                result = (name.Length * pointsByName) / 2;
                points += result;
                if (points >= 1250.5) break;
            }
            if(points>=1250.5)
            {
                Console.WriteLine($"Congratulations, {nominee} got a nominee for leading role with {points:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {nominee} you need {1250.5-points:f1} more!");
            }
        }
    }
}
