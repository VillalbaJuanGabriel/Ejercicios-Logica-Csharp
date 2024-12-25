using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 11:
             * 
             * Hacer un programa para ingresar 10 números y luego calcule y emita el mayor de los primos de la lista. 
             * En caso de no haber ningún número primo, deberá aclararlo con un cartel.
             * 
             */

            // Declaración de Variables:

            int numero, contador, primoMayor;
            bool esPrimo;

            esPrimo = false;
            primoMayor = 0;


            // Ciclo For Principal:

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                contador = 0;

                // Ciclo For Interno:

                for(int x = 1; x <= numero; x++)
                {
                    // Condicional para determinar si es Primo o no:

                    if (numero % x == 0) contador++;
                }

                // Condicional para buscar el Primo Mayor:

                if(contador == 2)
                {
                    if (!esPrimo)
                    {
                        primoMayor = numero;
                        esPrimo = true;
                    } else if(numero > primoMayor)
                    {
                        primoMayor = numero;
                    }
                }
            }

            // Se imprime el resultado final por pantalla:

            if(primoMayor == 0) Console.WriteLine("No se ingresaron Números Primos.");
            else Console.WriteLine($"Primo Mayor: {primoMayor}.");

            Console.ReadKey();

        }
    }
}
