using System;

namespace areaoffigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if(name =="square")
            {
                double a=double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", a*a); 
            }    
            else if (name=="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", a * b);
            }
            else if(name=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", Math.PI * r *r);
            }    
            else if(name=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}",a *h/2);
            }  
        }
    }
}
