using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 03:
             * 
             * Hacer un programa que solicite 100 números enteros y los guarde en un vector. 
             * Luego recorrer ese vector para calcular el promedio. 
             * Mostrar por pantalla los valores del vector que son mayores al promedio calculado.
             * 
             */

            // Declaración de Variables:

            int acumulador, contador, mayor, promedio;

            // Declaración del Vector: 

            int[] numVector = new int[10];

            // Carga del Vector:

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un Número: ");
                numVector[i] = int.Parse(Console.ReadLine());
            }

            acumulador = contador = 0;

            // Recorrida del Ciclo para la Acumulación y Contador de los Números:

            for (int i = 0; i < 100; i++)
            {
                acumulador += numVector[i];
                contador++;
            }

            // Cálculo del Promedio:

            promedio = acumulador / contador;
            mayor = 0;


            // Recorrida del Ciclo para Mostrar por Pantalla los Mayores al Promedio: 

            Console.WriteLine("Los Números Mayores al Promedio son: ");

            for (int i = 0; i < 100; i++)
            {
                if (numVector[i] > promedio) Console.WriteLine(numVector[i]);
                
            }

            Console.ReadKey();

        }
    }
}
