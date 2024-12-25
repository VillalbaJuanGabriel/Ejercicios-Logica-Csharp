using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 08:
             * 
             * Hacer un programa que solicite 20 números y luego mostrar por pantalla el 
             * menor de ellos y la posición en la que fue encontrado.
             * 
             */

            // Declaración de Variables:

            int numero, minimo, posicion;

            minimo = 0;
            posicion = 0;

            // Ciclo FOR:

            for (int i = 0; i < 10; i++)
            {
                // Ingreso de Números:

                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                // Condicional para buscar el número menor y su posición:


                if (i == 0)
                {
                    minimo = numero;
                    posicion = i + 1;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                    posicion = i + 1;
                }
            }

            // Se imprime por pantalla el número minimo y su posición:

            Console.WriteLine($"El número minimo es: {minimo}.");
            Console.WriteLine($"Fue ingresado en la posición: {posicion}.");

            Console.ReadKey();

        }
    }
}
