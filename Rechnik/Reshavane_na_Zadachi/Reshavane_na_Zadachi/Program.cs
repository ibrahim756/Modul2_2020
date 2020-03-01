using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reshavane_na_Zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ukazatel = new Dictionary<string, string>();
            var linia = Console.ReadLine().Split();

            while (true)
            {
                var command = linia[0];

                if (command=="END")
                {
                    break;
                }

                if (command=="Add")
                {
                    var name = linia[1];
                    var number = linia[2];
                    if (ukazatel.ContainsKey(name))
                    {
                        ukazatel[name] = number;
                    }
                    else
                    {
                        ukazatel.Add(name, number);
                    }
                }

                if (command=="print")
                {
                    var name = linia[1];
                    if (ukazatel.ContainsKey(name))
                    {
                        Console.WriteLine($"{name}=> ukazatel{name}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }

                }
                linia = Console.ReadLine().Split();



            }
                
                
        }
    }
}
