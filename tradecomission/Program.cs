using System;

namespace tradecomission
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double bonus = 0;
            switch(city)
            {
                case "Sofia":
                    if(sales>=0 && sales <=500)
                    {
                        bonus = sales * 0.05;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if(sales> 500&& sales <=1000)
                    {
                        bonus = sales * 0.07;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        bonus = sales * 0.08;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales > 10000)
                    {
                        bonus = sales * 0.12;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        bonus = sales * 0.045;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        bonus = sales * 0.075;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        bonus = sales * 0.1;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales > 10000)
                    {
                        bonus = sales * 0.13;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        bonus = sales * 0.055;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        bonus = sales * 0.08;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        bonus = sales * 0.12;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales > 10000)
                    {
                        bonus = sales * 0.145;
                        Console.WriteLine("{0:f2}", bonus);
                    }
                    else if (sales<0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
