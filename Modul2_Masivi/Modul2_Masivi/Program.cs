using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi den ot sedmicata kato chislo: ");
            int day = int.Parse(Console.ReadLine());
            string[] days = { "pon", "vtor", "srqda", "che", "pet", "sub", "ned" };

            if (day>=1 && day<=7)
            {
                Console.WriteLine(days[day-1]);
            }
            else
            {
                Console.WriteLine("invalid date");
            }
        }
    }
}
