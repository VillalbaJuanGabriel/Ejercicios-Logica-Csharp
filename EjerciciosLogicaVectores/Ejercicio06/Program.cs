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
             * Dada una lista de 10 números, cargarlos en un vector. 
             * Luego detectar si en el vector hay algún elemento repetido. 
             * De haberlo, indicarlo con un cartel aclaratorio “Hay repetidos”, de lo contrario indicar “No hay repetidos”.
             * Pista: usar ciclos combinados.
             * 
             */

            // Declaración de Variables:

            int repetido, contador;
            bool bandera;
            bandera = false;

            // Declaración del Vector: 

            int[] numVector = new int[10];

            // Carga del Vector con Números:

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un Número: ");
                numVector[i] = int.Parse(Console.ReadLine());
            }

            // Ciclo Combinado para Recorrer los Mismos y Buscar Números Repetidos:

            for(int i = 0; i < 10; i++)
            {
                repetido = numVector[i];
                contador = 0;

                for (int y = 0; y < 10; y++)
                {
                    if (repetido == numVector[y]) contador++;
                }

                if (contador >= 2) bandera = true;

            }

            // Se Emite por pantalla si hay o no repetidos:

            if(bandera == true) Console.WriteLine("Hay Repetidos.");
            else Console.WriteLine("No hay Repetidos.");

            Console.ReadKey();
        }
    }
}
