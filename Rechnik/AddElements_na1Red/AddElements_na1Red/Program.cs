using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElements_na1Red
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> market = new Dictionary<string, int>();
            var linia = Console.ReadLine().Split();
            while (true)
            {
                string stoka = linia[0];
                if (stoka=="stop")
                {
                    break;
                }
                int price = int.Parse(linia[1]);
                if (market.ContainsKey(stoka))
                {
                    
                    market[stoka] = market[stoka]+ price;
                }
                else
                {
                    market.Add(stoka, price);
                }

                

                market.Add(stoka,price);
                linia = Console.ReadLine().Split();

            }
            foreach (var item in market)
            {
                Console.WriteLine($"{item.Key} => {item.Value} lewa");
            }
        }
    }
}
