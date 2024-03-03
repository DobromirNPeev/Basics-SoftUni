using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 1;
            double sum = 0;
            int excluded = 0;
            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    excluded++;
                    break;
                }
                sum += grade;
                grades++;
            }
            double average = sum / 12;
            if (excluded == 0)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
            else if(excluded != 0)
            {
                Console.WriteLine($"{name} has been excluded at {grades} grade");
            }
        }
    }
}
