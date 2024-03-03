using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputExamTimeHour = int.Parse(Console.ReadLine());
            int inputExamTimeMinute = int.Parse(Console.ReadLine());
            int inputArrivalHour = int.Parse(Console.ReadLine());
            int inputArrivalMinute = int.Parse(Console.ReadLine());

            int timeExam = (inputExamTimeHour * 60) + inputExamTimeMinute;
            int timeArrival = (inputArrivalHour * 60) + inputArrivalMinute;
            if (timeArrival == timeExam)
            {
                Console.WriteLine("On time");
            }
            else if (timeExam - timeArrival <= 30 && timeExam > timeArrival)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{timeExam - timeArrival} minutes before the start");
            }
            else if (timeExam - 30 > timeArrival)
            {
                if (timeExam - timeArrival < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{timeExam - timeArrival} minutes before the start");
                }
                else if (timeExam - timeArrival >= 60)
                {
                    double time = (timeExam - timeArrival) / 60;
                    double minutes = (timeExam - timeArrival) % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{time}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{time}:{minutes} hours before the start");
                    }
                }
            }
            else if (timeArrival > timeExam)
            {
                if (timeArrival - timeExam < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{Math.Abs(timeArrival - timeExam)} minutes after the start");

                }
                else if (timeArrival >= 60)
                {
                    double time = (timeArrival-timeExam) / 60;
                    double minutes = (timeArrival - timeExam) % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{time}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{time}:{minutes} hours after the start");
                    }
                }
            }
        }
    }
}