using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunkcii
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 22, 18, 1, 7, 3, 4, 9, 6, 8, 4, 12, 9 };
            int[] number = { 2,3,8,5,2,4,5,7,5,2 };
            Console.WriteLine(string.Join(" ",nums));
            nums = nums.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ", nums));

            int s = nums.Sum();
            Console.WriteLine($"Сума на нов масив: s={s}");
            int counter = nums.Length;
            Console.WriteLine($"Брой на нов масив: br={counter}");
            nums = nums.Where(n => n >= 6).ToArray();
            Console.WriteLine(string.Join(" ", nums));

            nums = nums.OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(" ", nums));

            nums = nums.OrderByDescending(y => y).ToArray();
            Console.WriteLine(string.Join(" ", nums));

            nums = nums.Take(3).ToArray();
            Console.WriteLine(string.Join(" ", nums));

            nums = nums.Select(x => x + 10).ToArray();
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine("number "+string.Join(" ", number));

            number = number.Distinct().ToArray();
            Console.WriteLine(string.Join(" ", number));





        }
    }
}
