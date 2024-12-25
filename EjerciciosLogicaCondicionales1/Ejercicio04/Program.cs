using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 04:
             * 
             * Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” 
             * si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
             * 
             */

            // Declaración de Variables:

            int numero;

            // Ingreso del Número:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // Condicional para determinar el Estado del Número:

            if(numero > 0)
                Console.WriteLine("Positivo.");
            else if(numero < 0)
                Console.WriteLine("Negativo.");
            else
                Console.WriteLine("Cero.");

            Console.ReadKey();

        }
    }
}
