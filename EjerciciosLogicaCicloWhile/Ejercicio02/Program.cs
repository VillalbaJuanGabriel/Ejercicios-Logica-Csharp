using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 02:
             * 
             * Hacer un programa para mostrar los números del 10 al 1. 
             * No se debe realizar ningún pedido de datos.
             * 
             */

            // Declaración de Variables:

            int i = 10;

            // Ciclo While:

            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.ReadKey();
        }
    }
}
