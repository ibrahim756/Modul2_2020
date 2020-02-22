using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Pr_02_ObrushtaneNaMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(' ').ToArray();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(word[i]);
            }

            //Обръщане на елементи на масив
            Array.Reverse(word);
            Console.WriteLine(string.Join(" ",word));
        }
    }
}
