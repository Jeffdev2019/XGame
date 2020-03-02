using System;
using System.Linq;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var numero in numeros.Where(n => n > 4))
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
