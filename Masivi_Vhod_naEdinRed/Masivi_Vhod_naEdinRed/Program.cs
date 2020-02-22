using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masivi_VhodIzhod1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] num = Console.ReadLine().Split(' ').ToArray();


            Console.WriteLine("====FOREACH=====");
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("====string.Join=====");

            Console.WriteLine(string.Join(" ", num));






        }
    }
}