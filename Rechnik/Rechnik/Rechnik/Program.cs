using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> person = new Dictionary<string, int>
            {
                {"Hristo",26 },
                {"Asen",25},
                {"Petar",28 },
                {"Ivan",23 },
                {"Petq",32 },
                {"Stefan",42 },



            }
            ;

            
            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}: {item.Value} age");
            }
            Console.WriteLine("===============");
            var sortperson = person.OrderBy(x => x.Key).ThenBy(x => x.Value);
                
            foreach (var item in sortperson)
            {
                Console.WriteLine($"{item.Key}: {item.Value} age");
            }
            Console.WriteLine("=========SortAges=======");
            var sortAgeDes = person.OrderByDescending(x=>x.Value);
            foreach (var item in sortAgeDes)
            {
                Console.WriteLine($"{item.Key}: {item.Value} age");
            }

        }
    }
}
