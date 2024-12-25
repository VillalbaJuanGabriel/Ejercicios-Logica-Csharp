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
             * Se ingresa una lista de 20 números en un vector. 
             * Se pide ordenar dichos números en forma decreciente (de mayor a menor). 
             * Mostrar el listado ordenado informando también la posición original de cada número en el vector.
             * Pista: usar ciclos combinados.
             * 
             */

            // Declaración de Variables:

            int auxiliar;


            // Declaración del Vector: 

            int[] vector = new int[20];

            // Vector para Cargar los 20 Números al Vector:

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un Número: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            int[] vectorPosicion = new int[20];

            // Vector para Cargar y luego Recorrer la Posición Original de Cada Número: 

            for(int i = 0; i < 20; i++)
            {
                vectorPosicion[i] = i + 1;
            }

            // Vector para Ordenarlos de Menor a Mayor:

            for(int i = 0; i < 20; i++)
            {
                for(int y = 0; y < 19; y++)
                {
                    if (vector[y] < vector[y + 1])
                    {
                        auxiliar = vector[y + 1];
                        vector[y + 1] = vector[y];
                        vector[y] = auxiliar;

                        auxiliar = vectorPosicion[y + 1];
                        vectorPosicion[y + 1] = vectorPosicion[y];
                        vectorPosicion[y] = auxiliar;
                    }
                }
            }

            // Se Emiten por pantalla las siguientes lineas de Código:

            // Vector Ordenado de Menor a Mayor:

            Console.WriteLine("Vector Ordenado de Menor a Mayor con el Método Burbuja (Burbujeo): ");

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Número: {vector[i]}. Posición: {vectorPosicion[i]}.");
            }

            Console.ReadKey();

        }
    }
}
