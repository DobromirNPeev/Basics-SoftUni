using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failed = int.Parse(Console.ReadLine());
            int failedtimes = 0;
            int solved = 0;
            double gradesSum = 0;
            string current = "";
            bool isFailed = true;
            while(failedtimes<failed)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedtimes++;
                }
                gradesSum += grade;
                solved++;
                current = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failed} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum/solved:f2}");
                Console.WriteLine($"Number of problems: {solved}");
                Console.WriteLine($"Last problem: {current}");
            }
        }
    }
}
