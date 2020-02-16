using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_word_6_CelZaguba
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int sum = 0;

            
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                sum +=a % b;


            }
            Console.WriteLine(sum);
        }
    }
}
