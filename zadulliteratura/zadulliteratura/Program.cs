using System;

namespace zadulliteratura
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiStr = int.Parse(Console.ReadLine());
            int str = int.Parse(Console.ReadLine());
            int broiDni = int.Parse(Console.ReadLine());
            //Да се отпечата на конзолата броят часове, които Жоро трябва да отделя за четене всеки ден.
            /*Общо време за четене на книгата: 212 страници / 20 страници за час = 10 часа общо
Необходимите часове на ден: 10 часа / 2 дни = 5 часа на ден*/
            int sumTime = broiStr / str;
            int otg = sumTime / broiDni;
            Console.WriteLine(otg);

        }
    }
}
