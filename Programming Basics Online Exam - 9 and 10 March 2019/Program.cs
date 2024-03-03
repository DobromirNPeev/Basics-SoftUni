using System;

namespace Programming_Basics_Online_Exam___9_and_10_March_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double racketPrice = double.Parse(Console.ReadLine());
            int racketN = int.Parse(Console.ReadLine());
            int trainersM = int.Parse(Console.ReadLine());
            double sum = racketPrice * racketN + (racketPrice / 6 * trainersM);
            sum += sum * 0.2;
            double paidByDjo = Math.Floor(sum / 8);
            double paidBySpo = Math.Ceiling(sum*7 / 8);
            Console.WriteLine($"Price to be paid by Djokovic {paidByDjo}");
            Console.WriteLine($"Price to be paid by sponsors {paidBySpo}");
        }
    }
}
