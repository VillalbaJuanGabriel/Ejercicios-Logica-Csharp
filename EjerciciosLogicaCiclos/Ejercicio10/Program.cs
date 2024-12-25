using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 10:
             * 
             * Hacer un programa que solicite 20 números y luego emitir por pantalla el 
             * máximo de los números pares y el mínimo de los números impares.
             * 
             */

            // Declaración de Variables:

            int numero, maxPar, minImpar;
            bool esPar, esImpar;

            maxPar = minImpar = 0;
            esPar = esImpar = false;

            // Ciclo For:

            for(int i = 0; i < 20; i++)
            {
                // Ingreso de los números:

                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                // Condicional para determinar el maximo par y el minimo impar:

                if(numero % 2 == 0)
                {
                    if (!esPar)
                    {
                        maxPar = numero;
                        esPar = true;
                    } else if(numero > maxPar)
                    {
                        maxPar = numero;
                    }
                } else
                {
                    if(numero % 2 != 0)
                    {
                        if (!esImpar)
                        {
                            minImpar = numero;
                            esImpar = true;
                        } else if(numero < minImpar)
                        {
                            minImpar = numero;
                        }
                    }
                }
            }

            // Se emiten los valores por pantalla:

            Console.WriteLine($"Máximo Par: {maxPar}.");
            Console.WriteLine($"Minimo Impar: {minImpar}.");

            Console.ReadKey();

        }
    }
}
