using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 01:
             * 
             * Hacer un programa que solicite 50 números enteros y los guarde en un vector.
             * Luego recorrer el vector y determinar e informar cuál es la suma de los valores del mismo.
             * 
             * Nota: usar dos ciclos: uno para guardar los números en el vector y otro para recorrerlo y leerlo.
             * 
             */

            // Declaración de Variables:

            int sumaVector;

            // Declaración del Vector: 

            int[] numVector = new int[50];

            // Carga del Vector con 50 Números:
            
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numVector[i] = int.Parse(Console.ReadLine());
            }

            sumaVector = 0;

            // Recorrido del Vector para la Suma de todos los Números ingresados:

            for (int i = 0; i < 5; i++)
            {
                sumaVector += numVector[i];
            }

            // Se emite la suma final por pantalla:

            Console.WriteLine($"La suma de todos los números del vector es: {sumaVector}.");

            Console.ReadKey();

        }
    }
}
