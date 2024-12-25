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
             * Hacer un programa que solicite el ingreso de un número y que luego emita un cartel 
             * por pantalla aclarando si el mismo es múltiplo de 5.
             * 
             */

            // Declaración de Variables:

            int numero;
            string multiplo;

            // Ingreso del Número:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // Operador Ternario para evaluar si es Multiplo de 5:

            multiplo = (numero % 5 == 0) ? "Es Múltiplo de 5." : "No es Múltiplo de 5.";

            // Se imprime el resultado por pantalla:

            Console.WriteLine(multiplo);

            Console.ReadKey();

        }
    }
}
