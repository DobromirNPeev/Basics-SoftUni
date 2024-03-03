using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            double sum;
            double allSum = 0;
            int count = 0;
            while (text != "Finish")
            {
                sum = 0;
                double grade;
                for(int i=1;i<=n;i++)
                {
                    grade= double.Parse(Console.ReadLine());
                    sum += grade;
                    allSum += grade;
                    count++;
                }
                Console.WriteLine($"{text} - {sum/n:f2}.");
                text = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {allSum/count:f2}.");
        }
    }
}
