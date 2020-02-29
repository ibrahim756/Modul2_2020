using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minionska_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mina = new Dictionary<string, int>();
            while (true)
            {
                string izkopaemo = Console.ReadLine();
                if (izkopaemo=="stop")
                {
                    break;
                }

                int kol = int.Parse(Console.ReadLine());
                if (mina.ContainsKey(izkopaemo))
                {
                    mina[izkopaemo] += kol;
                }
                else
                {
                    mina.Add(izkopaemo, kol);
                }

            }
            foreach (var item in mina)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
