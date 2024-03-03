using System;

namespace uprj
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 0;
            switch (type)
            {
                case "Premiere":
                    price = 12.00;
                    Console.WriteLine("{0:f2} leva",r *c*price);
                    break;
                case "Normal":
                    price = 7.50;
                    Console.WriteLine("{0:f2} leva",r * c * price);
                    break;
                case "Discount":
                    price = 5.00;
                    Console.WriteLine("{0:f2} leva",r * c * price);
                    break;

            }
        }
    }
}
