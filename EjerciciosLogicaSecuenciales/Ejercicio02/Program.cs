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
             * Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
             * 
             */

            // Declaración de Variables:

            int numero, elevacionCubo;

            // Ingreso del Número:

            Console.WriteLine("Ingrese un número para elevarlo al cubo: ");
            numero = int.Parse(Console.ReadLine());

            // Cálculo de Elevación al Cubo:

            elevacionCubo = numero * numero * numero;

            // Emisión de Resultado por Pantalla:

            Console.WriteLine($"El número {numero} elevado al cubo es: {elevacionCubo}.");

            Console.ReadKey();

        }
    }
}
