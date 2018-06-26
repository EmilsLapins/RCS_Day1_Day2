using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            NeatgriezVertibu();
            ArParametriem(20, 100);
            ArParametriem(2, 11);
            ArParametriem(4, 5);

            int atbilde = ArReturn(10, 20);
            Console.WriteLine(atbilde);
            Console.ReadLine();

           
            int skaitlis123 = AtgriezSkaitli();
            Console.WriteLine(skaitlis123);

            Console.ReadLine();

        }

        static void NeatgriezVertibu() // deklarejam funkciju // Semikolu (;) neliekam
        {

            Console.WriteLine("1. funkcija"); // funkcijas kermenis
            Console.WriteLine("Bez input un output");
        }

        static void ArParametriem(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);

        }

        static int ArReturn(int a, int b)
        {
            int result = a + b;
            return result;  // atgriez vertibu, ko talak var izmantot static void Main 

        }

        static int AtgriezSkaitli()
        {
            Console.WriteLine("Ieraksti skaitli ");
            string Skaitlis1 = Console.ReadLine();
            int Skaitlis2 = Convert.ToInt16(Skaitlis1);
            return Skaitlis2;
        }

        
    }
}
