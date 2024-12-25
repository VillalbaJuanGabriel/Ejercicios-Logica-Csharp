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
             * Hacer un programa para ingresar una lista de números que corta cuando se 
             * ingresa un cero y luego mostrar: la cantidad de números primos, 
             * la cantidad de números pares, la cantidad de positivos y la cantidad de negativos.
             * 
             */

            // Declaración de Variables:

            int numero, contador, contadorPrimos, contadorPares, contadorPositivos, contadorNegativos;

            // Inicialización de todos los contadores en 0, en una sola línea:

            contador = contadorPrimos = contadorPares = contadorPositivos = contadorNegativos = 0;


            // Ingreso de los números:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // Ciclo While:

            while(numero != 0)
            {
                // Ciclo For y Condicionales para determinar la Cantidad de Números Primos:

                contador = 0;

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0) contador++;
                }

                if (contador == 2) contadorPrimos++;

                // Condicional para determinar la Cantidad de Números Pares:

                if (numero % 2 == 0) contadorPares++;

                // Condicional para determinar la Cantidad de Números Positivos y Negativos:

                if (numero > 0) contadorPositivos++;
                else contadorNegativos--;

                // Se vuelven a pedir los números:

                Console.WriteLine("Ingrese otro número: ");
                numero = int.Parse(Console.ReadLine());
            }

            // Se emiten las Cantidades correspondientes por pantalla:

            Console.WriteLine($"Contador de Números Primos: {contadorPrimos}.");
            Console.WriteLine($"Contador de Números Pares: {contadorPares}.");
            Console.WriteLine($"Contador de Números Positivos: {contadorPositivos}.");
            Console.WriteLine($"Contador de Números Negativos: {contadorNegativos}.");

            Console.ReadKey();

        }
    }
}
