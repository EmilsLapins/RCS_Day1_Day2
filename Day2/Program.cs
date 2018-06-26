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
            

            int skaitlis123 = AtgriezSkaitli();
            Console.WriteLine(skaitlis123);


            int Saskaititie = SaskaitamSkaitlus();
            Console.WriteLine(Saskaititie + " ir rezultats");


            int Atnemtie = AtnemamSkaitlus(11, 10); // Atnem parametros noraditos skaitlus 
            Console.WriteLine(Atnemtie);

           
            

            Console.ReadLine();
            

        }

        static void NeatgriezVertibu() // deklarejam funkciju // Semikolu (;) neliekam
        {

            Console.WriteLine("1. funkcija"); 
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

        // 2 funckijas: 1. saskaita, 2. atnem
        static int SaskaitamSkaitlus()
        {
            Console.WriteLine("Ieraksti skaitli a: ");
            string SkaitlisA = Console.ReadLine();
            int SkA = Convert.ToInt16(SkaitlisA);

            Console.WriteLine("Ieraksti skaitli b: ");
            string SkaitlisB = Console.ReadLine();
            int SkB = Convert.ToInt16(SkaitlisB);

            int result = SkA + SkB; 

            return result;
        }

        static int AtnemamSkaitlus(int a, int b)
        {
            int result = a - b;
            return result;
        }

    }
}
