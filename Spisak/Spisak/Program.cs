using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisak
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> spisak = new List<int>();
            Console.WriteLine("Vavedete broy elementi na spisak");
            int brEl = int.Parse(Console.ReadLine());

          

            for (int i = 0; i < brEl; i++)
            {
                Console.Write($"spisak[{i}]=");
                int el = int.Parse(Console.ReadLine());
                spisak.Add(el);
            }
            
            
                Console.WriteLine(string.Join(" ",spisak));
            

            for (int i = 0; i < spisak.Count; i++)
            {
                if (spisak[i]<0)
                {
                    spisak.Remove(spisak[i]);
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ", spisak));
        }
    }
}
