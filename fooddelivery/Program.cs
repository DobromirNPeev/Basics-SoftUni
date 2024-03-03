using System;

namespace fooddelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            /*⦁	Пилешко меню –  10.35 лв. 
  ⦁	Меню с риба – 12.40 лв. 
  ⦁	Вегетарианско меню  – 8.15 лв. 
  */
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());
            double numCM = chickenMenu * 10.35;
            double numFM = fishMenu * 12.40;
            double numVM = veganMenu * 8.15;
            double sumMenu = numCM + numFM + numVM;
            double dessert = sumMenu * 0.2;
            Console.WriteLine(sumMenu+dessert+2.5);
        }
    }
}
