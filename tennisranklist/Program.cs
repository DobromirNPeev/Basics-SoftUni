using System;

namespace tennisranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            double points = 0;
            int counter = 0;
            int counter1 = 0;
            for(int i=1;i<=n;i++)
            {
                string type=Console.ReadLine();
                switch (type)
                {
                    case "W":
                        points += 2000;
                        counter++;
                        counter1++;
                        break;
                    case "F":
                       points +=1200;
                        counter++;
                        break;
                    case "SF":
                        points += 720;
                        counter++;
                        break;
                }
            }
            points += startingPoints;
            double diff = points - startingPoints;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(diff/n)}");
            Console.WriteLine($"{(double)counter1/counter*100,0:f2}%");
        }
    }
}
