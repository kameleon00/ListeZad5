using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<TKey, TValue>

            Dictionary<string, int> gradovi = new Dictionary<string, int>()
            {
                {"Beograd", 2000000 },
                {"Nis", 1400000 },
                {"Kraljevo", 400000 },
            };
            Console.WriteLine("Grad - Stanovnici");
            foreach (KeyValuePair<string, int> grad in gradovi)
                Console.WriteLine(grad.Key + " - " + grad.Value);
            Console.WriteLine("=====================================");

            Console.WriteLine("Preko var-a");
            foreach (var grad in gradovi)
                Console.WriteLine(grad);
            Console.WriteLine("=====================================");

            Console.WriteLine("Samo vrednosti");
            foreach (var grad in gradovi.Values)
                Console.WriteLine(grad);
            Console.WriteLine("=====================================");

            Console.WriteLine("Samo kljucevi");
            foreach (var grad in gradovi.Keys)
                Console.WriteLine(grad);
            Console.WriteLine("=====================================");

            Console.ReadLine();
        }
    }
}
