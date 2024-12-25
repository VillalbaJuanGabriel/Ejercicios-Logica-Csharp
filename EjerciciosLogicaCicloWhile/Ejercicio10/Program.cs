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
             * Hacer un programa que solicite una lista de números que corta cuando se
             * ingresa un cero y luego emitir por pantalla el máximo de los números
             * negativos y el mínimo de los números positivos.
             * 
             */

            // Declaración de Variables:

            int numero, maximoNegativo, minimoPositivo;

            maximoNegativo = minimoPositivo = 0;

            // Ingreso de los números:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // Ciclo While:

            while(numero != 0)
            {

                // Condicional para buscar el Minimo Positivo y el Máximo Negativo:

                if(numero > 0)
                {
                    minimoPositivo = numero;

                    if(numero < minimoPositivo)
                    {
                        minimoPositivo = numero;
                    }
                } else
                {
                    maximoNegativo = numero;

                    if (numero > maximoNegativo)
                    {
                        maximoNegativo = numero;
                    }
                }
               
                // Se vuelven a pedir los números:

                Console.WriteLine("Ingrese otro número: ");
                numero = int.Parse(Console.ReadLine());
            }

            // Se emiten por pantalla los números correspondientes: 

            Console.WriteLine($"Minimo Positivo: {minimoPositivo}.");
            Console.WriteLine($"Maximo Negativo: {maximoNegativo}.");

            Console.ReadKey();

        }
    }
}
