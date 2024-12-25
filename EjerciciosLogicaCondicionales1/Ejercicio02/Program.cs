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
             * Hacer un programa para ingresar dos números distintos y luego se muestre por pantalla el menor de ellos.
             * 
             */

            // Declaración de Variables:

            int num1, num2;
            string menor;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            // Operador Ternario para determinar el número menor:

            menor = (num1 < num2) ? $"El número {num1} es Menor." : $"El número {num2} es Menor.";

            // Se emite el menor por pantalla:

            Console.WriteLine(menor);

            Console.ReadKey();

        }
    }
}
