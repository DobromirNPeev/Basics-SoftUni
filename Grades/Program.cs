using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsNum = int.Parse(Console.ReadLine());
            double sum= 0;
            double topCount = 0;
            double middleCount1 = 0;
            double middleCount2 = 0;
            double failCount = 0;
            for(int i = 1; i <= studentsNum; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5.00)
                {
                    topCount++;
                    sum += grade;
                }
                else if(grade>=4.00 && grade <= 4.99)
                {
                    middleCount1++;
                    sum += grade;
                }
                else if(grade>=3.00 && grade <= 3.99)
                {
                    middleCount2++;
                    sum += grade;
                }
                else if (grade < 3)
                {
                    failCount++;
                    sum += grade;
                }
            }
            double top = topCount / studentsNum * 100;
            double middle1 = middleCount1 / studentsNum * 100;
            double middle2 = middleCount2 / studentsNum * 100;
            double fail = failCount / studentsNum * 100;
            Console.WriteLine($"Top students: {top:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {middle1:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {middle2:f2}%");
            Console.WriteLine($"Fail: {fail:f2}%");
            Console.WriteLine($"Average: {sum / studentsNum:f2}");
        }
    }
}
