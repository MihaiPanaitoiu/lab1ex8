using System;

namespace lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 8
                Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
                daca x este divizibil cu y.
                 In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
                “indivizibil”.
             */

            Console.WriteLine("Acest program iti va arata daca numere sunt divizibile");

            Console.WriteLine("x = ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("y = ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(x % y == 0 ? "divizibil" : "indivizibil");
        }
    }
}
