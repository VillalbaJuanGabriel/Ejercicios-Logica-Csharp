using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 09:
             * 
             * Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de 
             * aquellas personas mayores a 18 años.
             * 
             */

            // Declaración de Variables:

            int edad, contador, acumulador;
            double promedio;

            acumulador = contador = 0;

            // Ciclo FOR:

            for(int i = 0; i < 20; i++)
            {
                // Ingreso de las Edades:

                Console.WriteLine("Ingrese su Edad: ");
                edad = int.Parse(Console.ReadLine());

                // Condicional para determinar los mayores a 18:

                if(edad > 18)
                {
                    acumulador += edad;
                    contador++;
                }
            }

            // Cálculo del Promedio:

            promedio = (double) acumulador / contador;

            // Se emite el Promedio por pantalla:

            Console.WriteLine($"Promedio de Mayores a 18 años: {promedio}.");

            Console.ReadKey();

        }
    }
}
