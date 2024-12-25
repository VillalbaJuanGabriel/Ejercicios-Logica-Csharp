using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 03:
             * 
             * Hacer un programa para ingresar dos números. Si el segundo es distinto de cero, 
             * calcular la división del primero por el segundo y mostrar el resultado por pantalla; 
             * caso contrario, emitir un cartel aclarando que no se puede dividir por cero.
             * 
             */

            // Declaración de Variables:

            double num1, num2, division;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            // Calculo de la División:

            division = num1 / num2;

            // Condicional para evaluar los Números:

            if(num2 != 0) Console.WriteLine($"Resultado de la División: {division}.");
            else Console.WriteLine("No se puede dividir por Cero.");

            Console.ReadKey();

        }
    }
}
