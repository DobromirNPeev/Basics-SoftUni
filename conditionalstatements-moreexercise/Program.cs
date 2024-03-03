using System;

namespace conditionalstatements_moreexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double litres1 = P1 * H;
            double litres2 = P2 * H;
            if(litres1+litres2<=V)
            {
                double pool = (litres1 + litres2)/V*100;
                double pipe1 = litres1 / (litres1+litres2) * 100;
                double pipe2 = litres2 / (litres1 + litres2) * 100;
                Console.WriteLine($"The pool is {pool:f2} % full. Pipe 1: {pipe1:f2} %. Pipe 2: {pipe2:f2} %.");
            }
            else if (litres1 + litres2>V)
            {
                double diff = (litres2 + litres1) - V;
                Console.WriteLine($"For {H:f2} hours the pool overflows with {diff:f2} liters.");
            }
        }
    }
}
