using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum4Chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(string.Join(" ",num));

           


            foreach (var item in num)
            {
                if (item>3)
                {
                    Console.WriteLine(item);
                }
            }
            


            
            
        }
    }
}
