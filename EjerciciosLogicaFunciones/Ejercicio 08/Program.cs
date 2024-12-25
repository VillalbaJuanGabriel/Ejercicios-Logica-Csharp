using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 08:
             * 
             * Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
             * A partir de dichos datos informar:
             *      a. El mayor de los números pares.
             *      b. La cantidad de números impares.
             *      c. El menor de los números primos.
             * Hacer uso de las funciones anteriormente desarrolladas.
             * 
             */

            // Declaración de Variables:

            int numero, numeroParMayor, contadorImpares, primoMenor;
            bool esPar, banderaMaxPar, esPrimo, banderaPrimo;

            numeroParMayor = 0;
            contadorImpares = 0;
            banderaMaxPar = false;

            primoMenor = 0;
            banderaPrimo = false;

            // Ingreso de los Números: 

            Console.WriteLine("Ingrese un Número: ");
            numero = int.Parse(Console.ReadLine());

            // Ciclo While para buscar Pares, Impares y Primos:

            while (numero != 0)
            {
                // Invocación de la Función Par:

                esPar = Par(numero);

                // Se Determina el Número Par Máximo y la Cantidad de Números Impares:

                if (esPar)
                {
                    if (!banderaMaxPar)
                    {
                        numeroParMayor = numero;
                        banderaMaxPar = true;
                    } else
                    {
                        if(numero > numeroParMayor)
                        {
                            numeroParMayor = numero;
                        }
                    }
                } else
                {
                    contadorImpares++;
                }

                // Invocación de la Función Primo:

                esPrimo = Primo(numero);

                // Se Determina cual es el Primo Menor:

                if (esPrimo)
                {
                    if (!banderaPrimo)
                    {
                        primoMenor = numero;
                        banderaPrimo = true;
                    } else
                    {
                        if(numero < primoMenor)
                        {
                            primoMenor = numero;
                        }
                    }
                }

                // Se Vuelven a pedir los Números:

                Console.WriteLine("Ingrese otro Número: ");
                numero = int.Parse(Console.ReadLine());
            }

            // Se Emite por Pantalla el Par Mayor, la Cantidad de Impares y el Primo Menor:

            Console.WriteLine($"Número Par Máximo: {numeroParMayor}.");
            Console.WriteLine($"Cantidad de Números Impares: {contadorImpares}.");
            Console.WriteLine($"Primo Menor: {primoMenor}.");

            Console.ReadKey();

        }

        // Declaración de las Funciones:

        // Función Par para Buscar Pares e Impares:

        static bool Par(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }

        // Función Primo para Buscar Números Primos:

        static bool Primo(int n)
        {
            int contador = 0;

            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0) contador++;
            }

            if (contador == 2) return true;
            else return false;
        }

    }
}
