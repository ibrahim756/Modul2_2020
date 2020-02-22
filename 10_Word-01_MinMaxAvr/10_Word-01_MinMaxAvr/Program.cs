using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Word_01_MinMaxAvr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ",num));

            int sumEl = num.Sum();
            Console.WriteLine($"Sum={sumEl}");

            int maxEl = num.Max();
            Console.WriteLine($"Max={maxEl}");

            int minEl = num.Min();
            Console.WriteLine($"Min={minEl}");

            double aveEl = num.Average();
            
            Console.WriteLine($"Average={aveEl:f2}");

        }
    }
}
