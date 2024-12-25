using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 04:
             * 
             * Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
             * Hacer un programa para ingresar números. 
             * El lote corta cuando se ingresa un número cero. 
             * Informar el promedio teniendo en cuenta sólo los números primos.
             * 
             */

            // Declaración de Variables:

            int numero, contadorPrimos, acumulador, promedio;
            contadorPrimos = acumulador = 0;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un Número: ");
            numero = int.Parse(Console.ReadLine());

            // Ciclo While para Ingresar Números, para Acumular y Contar la Cantidad de Primos:

            while(numero != 0)
            {
                // Se Invoca la Función Primo en un Condicional:

                if (Primo(numero))
                {
                    acumulador += numero;
                    contadorPrimos++;
                }

                Console.WriteLine("Ingrese otro Número: ");
                numero = int.Parse(Console.ReadLine());
            }

            // Se Calcula el Promedio de los Números Primos:

            promedio = acumulador / contadorPrimos;

            // Se Emite por Pantalla el Promedio de Números Primos:

            Console.WriteLine($"El Promedio de Números Primos es: {promedio}.");

            Console.ReadKey();
            
        }

        // Declaración de la Función:

        static bool Primo(int numero)
        {
            int contador = 0;

            for(int i = 1; i <= numero; i++)
            {
                if (numero % i == 0) contador++;
            }

            if (contador == 2) return true;
            else return false;
        }

    }
}
