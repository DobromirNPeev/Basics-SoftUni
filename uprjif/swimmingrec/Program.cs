using System;

namespace swimmingrec
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double rec = double.Parse(Console.ReadLine());
            double dist = double.Parse(Console.ReadLine());
            double swim = double.Parse(Console.ReadLine());
            double ivan = dist * swim;
            dist = dist / 15;
            dist=Math.Floor(dist);
            dist = dist * 12.5;
            dist = Math.Round(dist, 2);
            ivan = ivan + dist;

            if(ivan<rec)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {ivan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {ivan-rec:f2} seconds slower.");
            }
            

        }
    }
}
