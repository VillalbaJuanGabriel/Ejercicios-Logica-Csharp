using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 01:
             * 
             * Hacer un programa para mostrar los números del 1 al 10. 
             * No se debe realizar ningún pedido de datos.
             * 
             */

            // Declaración de Variables:

            int i = 1;

            // Ciclo While:

            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();

        }
    }
}
