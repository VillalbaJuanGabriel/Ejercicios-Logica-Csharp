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
             * Hacer un programa para ingresar un número y mostrar por pantalla un cartel aclaratorio 
             * si el mismo es PAR o IMPAR.
             * 
             */

            // Declaración de Variables:

            int numero;
            string parOImpar;

            // Ingreso del Número:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // Operador Ternario para determinar si el Número es Par o Impar:

            parOImpar = (numero % 2 == 0) ? "PAR." : "IMPAR.";

            // Se emite el resultado por pantalla:

            Console.WriteLine(parOImpar);

            Console.ReadKey();

        }
    }
}
