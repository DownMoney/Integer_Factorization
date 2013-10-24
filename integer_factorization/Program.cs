using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace integer_factorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
           double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            double c = fermant(d);
            Console.WriteLine(c.ToString());
            while (c != 1)
            {
                double a = d / c;
                Console.WriteLine(a.ToString());
                c=fermant(a);
                Console.WriteLine(c.ToString());
            }            
            Console.ReadLine();
        }

       static double fermant(double n)
        {
            double a = Math.Ceiling(Math.Sqrt(n));
            double b = a * a - n;

            while (!isSquare(b))
            {
                a++;
                b = a * a - n;
            }     
           double x=a - Math.Sqrt(b);
           if ((x).ToString().Contains("."))
               x = 1;
            return x;
        }

       static bool isSquare(double a)
        {
            string s = Math.Sqrt(a).ToString();
            if (s.Contains("."))
                return false;
            else
                return true;
        }
    }
}
