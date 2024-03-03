using System;

namespace shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            double bill = 0.0;
           double N1;
           double M1;
            double P1;
            N1 = 250 * N;
            M1 = 0.35 * N1 *M;
            P1 = 0.1 * N1 * P;
            bill = N1 + M1 + P1;
            if(N>M)
            {
                bill = bill * 0.85;
            }

            if(budget>=bill)
            {
                budget = budget - bill ;
                Console.WriteLine($"You have {budget:f2} leva left!"); 

            }
            else if(bill>budget)
            {
                bill =  bill- budget;
                Console.WriteLine($"Not enough money! You need {bill:f2} leva more!");
            }
        }
    }
}
