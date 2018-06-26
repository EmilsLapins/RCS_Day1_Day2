using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabdienProgramma
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ludzu ievadiet savu vardu: "); // Jauta ievadit vardu
            string virkne2 = Console.ReadLine(); // ievadi saglabajam "string virkne2"

            Console.WriteLine("Ievadiet savu vecumu: ");
            string vecums1 = Console.ReadLine();

            // printejam ievadi, izveidojot pilnu teikumu    
            Console.WriteLine("Labdien " + virkne2 + ", prieks Jus redzet." + " Jums ir " + vecums1 + " gadi.");

            Console.ReadLine();
        }
    }
}
