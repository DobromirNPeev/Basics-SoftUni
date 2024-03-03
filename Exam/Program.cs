using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = int.Parse(Console.ReadLine());
            double twoCount = 0;
            double threeCount = 0;
            double fourCount = 0;
            double fiveCount = 0;
            double average = 0;
            double sum = 0;
            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 3)
                {
                    twoCount++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    threeCount++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    fourCount++;
                }
                else if (grade >= 5)
                {
                    fiveCount++;
                }
                sum += grade;
            }
            Console.WriteLine($"Top students: {fiveCount / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourCount / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeCount / students * 100:f2}%");
            Console.WriteLine($"Fail: {twoCount / students * 100:f2}%");
            average = sum / students;
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
