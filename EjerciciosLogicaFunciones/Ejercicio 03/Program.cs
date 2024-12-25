using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 03:
             * 
             * Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
             * Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
             * 
             */

            // Declaración de Variables:

            int numero, contador;
            contador = 0;

            // Ciclo For para ingresar los 20 Números:

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un Número: ");
                numero = int.Parse(Console.ReadLine());

                // Se Invoca la Función Primo en un Condicional:

                if (Par(numero)) contador++;
            }

            // Se Emite la Cantidad de Pares por Pantalla:

            Console.WriteLine($"La Cantidad de Números Pares Ingresados es: {contador}.");

            Console.ReadKey();

        }

        // Declaración de la Función:

        static bool Par(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }

    }
}
