using System;

namespace lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex7
            Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar
                 In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
                 Google: even and odd number */

            Console.WriteLine("Intordu numarul: ");

            int i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("Numarul introdus este par");
            }
            else
            {
                Console.WriteLine("Numarul introdus este impar");
            }
        }
    }
}
