using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 02:
             * 
             * Hacer un programa que solicite 50 números enteros y los guarde en un vector.
             * Luego recorrer todos los elementos del vector y determinar cuál es el valor máximo y su posición dentro del vector.
             * 
             */

            // Declaración de Variables:

            int valorMax, posicion;

            // Declaración del Vector: 

            int[] numVector = new int[50];

            // Carga de los 50 Números al Vector:

            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numVector[i] = int.Parse(Console.ReadLine());
            }

            valorMax = posicion = 0;

            // Recorrido del Vector para buscar el Máximo y su Posición:

            for (int i = 0; i < 50; i++)
            {

                if (i == 0)
                {
                    valorMax = numVector[i];
                    posicion = i + 1;
                } else
                {
                    if (numVector[i] > valorMax)
                    {
                        valorMax = numVector[i];
                        posicion = i + 1;
                    }
                }
            }

            // Se Emite por pantalla el Número el Máximo y su Posición:

            Console.WriteLine($"El Número Mayor es: {valorMax} y está en la Posición: {posicion}.");

            Console.ReadKey();

        }
    }
}
