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
             * Hacer un programa que solicite el ingreso de 10 números y que muestre el
             * mayor de ellos por pantalla. 
             * Solo se debe emitir UN valor por pantalla.
             * 
             */

            // Declaración de Variables:

            int numero, mayor;

            mayor = 0;

            // Ciclo For:

            for(int i = 0; i < 10; i++)
            {
                // Ingreso de los Números:

                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if (i == 0)
                    mayor = numero;
                else if (numero > mayor)
                    mayor = numero;
                
            }

            // Se imprime el Mayor por pantalla:

            Console.WriteLine($"Numero Mayor: {mayor}.");

            Console.ReadKey();

        }
    }
}
