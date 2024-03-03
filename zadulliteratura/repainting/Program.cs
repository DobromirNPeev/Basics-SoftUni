using System;

namespace repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*⦁	Необходимо количество найлон (в кв.м.) - цяло число в интервала [1... 100]
⦁	Необходимо количество боя (в литри) - цяло число в интервала [1…100]
⦁	Количество разредител (в литри) - цяло число в интервала [1…30]
⦁	Часовете, за които майсторите ще свършат работата - цяло число в интервала [1…9]
*/
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine()); 
            double safeNylon = (nylon + 2) * 1.50;
            double paintLitres = (paint + (paint * 0.1)) * 14.50;
            thinner = thinner * 5;
            double expensesSum = safeNylon + paintLitres + thinner+0.4;
            double payWorking = (expensesSum * 0.3)*workingHours;
            double sum = expensesSum+payWorking;
            Console.WriteLine($"{sum} ");
        }
    }
}
