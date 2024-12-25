using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 06:
             * 
             * Hacer un programa que solicite UN número y luego calcule y emita un 
             * cartel aclaratorio si el mismo es primo o no es primo.
             * 
             */

            // Declaración de Variables:

            int numero, contador;

            contador = 0;

            // Ingreso del Número:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // Ciclo For:

            for(int i = 1; i <= numero; i++)
            {
                // Condicional para buscar el número primo:

                if (numero % i == 0) contador++;
            }

            // Condicional para determinar si el número es Primo o no.

            if(contador == 2) Console.WriteLine("Es Primo.");
            else Console.WriteLine("No es Primo.");

            Console.ReadKey();

        }
    }
}
