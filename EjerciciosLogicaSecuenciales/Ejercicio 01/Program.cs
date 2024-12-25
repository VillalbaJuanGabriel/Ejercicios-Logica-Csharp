using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Ejercicio 01:
             * 
             * Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
             * 
             */

            // Declaración de Variables:

            int num1, num2, resultadoSuma;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            // Cálculo de la Suma:

            resultadoSuma = num1 + num2;

            // Se Emite por Pantalla el Resultado:

            Console.WriteLine($"El resultado de la suma es: {resultadoSuma}.");

            Console.ReadKey();

        }
    }
}
