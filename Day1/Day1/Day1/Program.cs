using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {  
            // Deklarejam mainigo piem. int vesels
            int vesels = 4; 
            Console.WriteLine(vesels);
            vesels = 5;
            Console.WriteLine(vesels);

            double komats = 5.2; // skaitlis ar komatu
            Console.WriteLine(komats);

            char simbols = '$';
            Console.WriteLine(simbols);

            string virkne = "abc";

            virkne = virkne + simbols; // string + char var apvienot, iznak 
            Console.WriteLine(virkne); // virkne tagad glaba abc$


            //Uzdevums 1 !
            Console.WriteLine("Ludzu ievadiet savu vardu: "); // Jauta ievadit vardu
            string virkne2 = Console.ReadLine(); // ievadi saglabajam "string virkne2"

            Console.WriteLine("Ievadiet savu vecumu: ");
            string vecums1 = Console.ReadLine();

            int rezultats = Convert.ToInt16(vecums1); // konvertejam string vecums1 uz int rezultats
            Console.WriteLine(rezultats);  

            // printejam ievadi, izveidojot pilnu teikumu    
            Console.WriteLine("Labdien " + virkne2 + ", prieks Jus redzet." + " Jums ir " + rezultats + " gadi.");

   

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
