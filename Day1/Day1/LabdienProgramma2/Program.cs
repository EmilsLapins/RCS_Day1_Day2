using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabdienProgramma2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uzdevums 2!
            // Gads
            // Dzimsanas gds
            // Vards

            Console.WriteLine("Kads sobrid ir gads: ");
            string sobridGads1 = Console.ReadLine();
            int sobridGads2 = Convert.ToInt16(sobridGads1);

            Console.WriteLine("Kura gada esi dzimis: ");
            string dzimsanasGads1 = Console.ReadLine();
            int dzimsanasGads2 = Convert.ToInt16(dzimsanasGads1);

            int vecums123 = sobridGads2 - dzimsanasGads2; // Atnemam 2018 - manu dzimsanas gadu 1994

            Console.WriteLine("Ka tevi sauc: ");
            string vards = Console.ReadLine();

            Console.WriteLine("Tevi sauc " + vards + " un tev ir " + vecums123 + " gadi.");

            Console.ReadLine();
        }
    }
}
