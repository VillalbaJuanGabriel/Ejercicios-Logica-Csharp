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
             * Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio 
             * si el mismo es primo o no es primo.
             * 
             */

            // Declaración de Variables:

            int numero, contador, i;

            // Ingreso del Número:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            contador = 0;
            i = 1;

            // Ciclo While:

            while(i <= numero)
            {
                // Condicional para evaluar si el número es o no es primo:

                if (numero % i == 0) contador++;

                i++;
            }

            // Condicional para emitir por pantalla si el número es o no es primo:

            if(contador == 2) Console.WriteLine("Es Primo.");
            else Console.WriteLine("No es Primo.");

            Console.ReadKey();

        }
    }
}
