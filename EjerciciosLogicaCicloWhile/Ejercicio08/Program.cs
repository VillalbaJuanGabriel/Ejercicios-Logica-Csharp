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
             * Hacer un programa que solicite una lista de números que corta cuando se 
             * ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.
             * 
             */

            // Declaración de Variables:

            int numero, menor, segundoMenor;

            // Ingreso de los números:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // Se inicializan las variables con el valor maximo posible para luego buscar los minimos:

            menor = int.MaxValue;
            segundoMenor = int.MaxValue;

            // Ciclo While:

            while (numero != 0)
            {
                // Condicionales para determinar los números menores:

                if (numero < menor)
                {
                    segundoMenor = menor;
                    menor = numero;
                }
                else
                {
                    if (numero < segundoMenor)
                    {
                        segundoMenor = numero;
                    }
                }

                // Se vuelven a pedir los números:

                Console.WriteLine("Ingrese otro número: ");
                numero = int.Parse(Console.ReadLine());
            }

            // Se emiten los números menores por pantalla:

            Console.WriteLine($"Número Menor: {menor}.");
            Console.WriteLine($"Segundo Menor: {segundoMenor}.");

            Console.ReadKey();

        }
    }
}
