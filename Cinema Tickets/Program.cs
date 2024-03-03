using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int studentCount = 0;
            int standardCount = 0;
            int kidCount = 0;
            double count = 0;
            while (movie != "Finish")
            {
                double freeSeats = int.Parse(Console.ReadLine());
                int notFinalCount = 0;
                for(int i = 0; i < freeSeats; i++)
                {
                    string type = Console.ReadLine();
                    if (type == "End") break;
                    if (type == "standard")
                    {
                        standardCount++;
                    }
                    else if (type == "kid")
                    {
                        kidCount++;
                    }
                    else if (type == "student")
                    {
                        studentCount++;
                    }
                    notFinalCount++;
                    count++;
                }
                double average = notFinalCount / freeSeats * 100; ;
                Console.WriteLine($"{movie} - {average:f2}% full.");
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {count}");
            Console.WriteLine($"{studentCount/count*100:f2}% student tickets.");
            Console.WriteLine($"{standardCount/count*100:f2}% standard tickets.");
            Console.WriteLine($"{kidCount/count*100:f2}% kids tickets.");
        }
    }
}
