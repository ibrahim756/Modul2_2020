using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_word_4_Pravougulnik
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            

            double s = a * b;
            double p = 2 * a + 2 * b;
            double c = Math.Sqrt(Math.Pow(a,2) + b * b);
            decimal c1=(decimal) Math.Sqrt(Math.Pow(a, 2) + b * b);
            int c2=(int) Math.Sqrt(Math.Pow(a, 2) + b * b);
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(c);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
           
        }
    }
}
