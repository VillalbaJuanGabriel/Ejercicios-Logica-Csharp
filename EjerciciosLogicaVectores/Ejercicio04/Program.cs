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
             * Dada una lista de 10 números enteros, cargarlos en un vector. 
             * Luego, determinar e informar si el vector está ordenado en forma creciente. 
             * Por ejemplo el vector con los valores 1, 3, 5, 7 y 9 está ordenado; el vector 1, 5, 3, 7 y 9 no lo está.
             * 
             */

            // Declaración de Variables:

            int mayor;
            bool bandera;

            // Declaración del Vector: 

            int[] numVector = new int[10];

            // Carga del Vector:

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numVector[i] = int.Parse(Console.ReadLine());
            }

            bandera = true;
            mayor = numVector[0];

            // Se Recorre el Vector para determinar Ordenamiento o no de los Números:

            for (int i = 0; i < 10; i++)
            {
                if (numVector[i] >= mayor) mayor = numVector[i];
                else bandera = false;
            }

            // Se Emite por pantalla la Condición del Ingreso de los Números:

            if(bandera) Console.WriteLine("Ordenados.");
            else Console.WriteLine("Desordenados.");

            Console.ReadKey();

        }
    }
}
