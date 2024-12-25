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
             * Hacer un programa que solicite 20 números y calcule y emita por pantalla 
             * cuántos son positivos (mayores a cero). 
             * Se debe mostrar un solo valor: el conteo final.
             * 
             */

            // Declaración de Variables:

            int numero, contador;

            contador = 0;

            // Ciclo For:

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                    contador++;
            }

            // Se imprime por pantalla la cantidad de positivos:

            Console.WriteLine($"Cantidad de Números Positivos: {contador}.");

            Console.ReadKey();

        }
    }
}
