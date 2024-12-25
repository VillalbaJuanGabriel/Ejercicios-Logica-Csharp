using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 05:
             * 
             * Hacer un programa que muestre los números del 1 al 100 de 5 en 5. 
             * Ejemplo: 0, 5, 10, 15, 20.... 100.
             * 
             */

            // Declaración de Variables:

            int i = 0;

            // Ciclo While:

            while(i <= 100)
            {
                Console.WriteLine(i);
                i += 5;
            }

            Console.ReadKey();

        }
    }
}
