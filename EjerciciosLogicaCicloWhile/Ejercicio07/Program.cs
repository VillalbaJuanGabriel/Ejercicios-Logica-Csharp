using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 07:
             * 
             * Hacer un programa que solicite una lista de números que corta cuando se 
             * ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición en la que fue ingresado.
             * 
             */

            // Declaracíón de Variables:

            int numero, maximo, posicion;

            // Ingreso de los números:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            posicion = 1;
            maximo = numero;

            // Ciclo While:

            while(numero != 0)
            {
                // Condicion para buscar el Máximo y su Posición:

                if(numero > maximo)
                {
                    maximo = numero;
                    posicion++;
                }

                // Se vuelven a pedir los números:

                Console.WriteLine("Ingrese otro número: ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Número Máximo: {maximo}.");
            Console.WriteLine($"Posición: {posicion}.");

            Console.ReadKey();

        }
    }
}
