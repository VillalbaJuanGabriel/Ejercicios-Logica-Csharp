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
             * Hacer un programa que solicite 10 números y luego mostrar por pantalla el 
             * máximo de ellos y la posición en la que fue ingresado.
             * 
             */

            // Declaración de Variables:

            int numero, maximo, posicion;

            maximo = 0;
            posicion = 0;

            // Ciclo FOR:

            for(int i = 0; i < 10; i++)
            {
                // Ingreso de Números:

                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                // Condicional para buscar el número mayor y su posición:


                if(i == 0)
                {
                    maximo = numero;
                    posicion = i + 1;
                } else if(numero > maximo)
                {
                    maximo = numero;
                    posicion = i + 1;
                }
            }

            // Se imprime por pantalla el número máximo y su posición:

            Console.WriteLine($"El número máximo es: {maximo}.");
            Console.WriteLine($"Fue ingresado en la posición: {posicion}.");

            Console.ReadKey();

        }
    }
}
