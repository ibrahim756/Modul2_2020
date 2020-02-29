using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElementsRechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            Console.Write("brElRechnik: ");
            int brEl = int.Parse(Console.ReadLine());

            for (int i = 0; i < brEl; i++)
            {
                Console.Write("Ime:");
                string name = Console.ReadLine();
                Console.Write("Nomer:");
                string number = Console.ReadLine();

                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }
                else
                {
                    phonebook.Add(name, number);
                }




                


            }


            foreach (var item in phonebook)
            {
                Console.WriteLine($"iME: {item.Key}=>noMER: {item.Value}");
            }
            phonebook.Remove("Asen");
            Console.WriteLine(string.Join(" ",phonebook));

            int contRe = phonebook.Count();
            Console.WriteLine($"Broi: {contRe}");
        }
    }
}
