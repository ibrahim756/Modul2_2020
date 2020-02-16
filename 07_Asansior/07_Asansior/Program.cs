using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Pr_1_Asansior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broi hora:");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Kapacitet:");
           
            int p = int.Parse(Console.ReadLine());
            int kursove = n / p;
            int ostatuk = n % p;
            if (ostatuk==0)
            {
                Console.Write($"Broi kursove {kursove}");
            }
            else
            {
                kursove++;
                Console.Write($"Broi kursove {kursove}");
            }


        }
    }
}
