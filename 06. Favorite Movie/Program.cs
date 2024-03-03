using System;

namespace _06._Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int count = 0;
            int sum = 0;
            int max = int.MinValue;
            string bestMovie = "";
            for(count=0;count<6;count++)
            {
                for (int i = 0; i < movie.Length; i++)
                {
                    char ascii = movie[i];
                    int num = ascii;
                    if (ascii >= 65 && ascii <= 90)
                    {
                        num -= movie.Length;
                        sum += num;
                    }
                    else if (ascii >= 97 && ascii <= 122)
                    {
                        num -= movie.Length * 2;
                        sum += num;
                    }
                    else
                    {
                        sum += num;
                    }
                }
                if (sum > max)
                {
                    max = sum;
                    bestMovie = movie;
                }
                movie = Console.ReadLine();
                if (movie == "STOP") break;
                sum = 0;
            }
            if (count == 6)
            {
                Console.WriteLine("The limit is reached.");
            }
            Console.WriteLine($"The best movie for you is {bestMovie} with {max} ASCII sum.");
        }
    }
}
