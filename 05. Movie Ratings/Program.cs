using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfFilms = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;
            string highest = "";
            string lowest = "";
            for (int i = 1; i <= numOfFilms; i++)
            {
                string movie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                sum += rating;
                if (rating > max)
                {
                    max = rating;
                    highest = movie;
                }
                if (rating < min)
                {
                    min = rating;
                    lowest = movie;
                }
            }
            Console.WriteLine($"{highest} is with highest rating: {max:f1}");
            Console.WriteLine($"{lowest} is with lowest rating: {min:f1}");
            Console.WriteLine($"Average rating: {sum/numOfFilms:f1}");

        }
    }
}
