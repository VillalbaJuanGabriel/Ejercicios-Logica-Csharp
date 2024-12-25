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
             * Hacer un programa para ingresar dos números y que luego emita por pantalla 
             * el mayor de ellos o un cartel aclaratorio “Son iguales” en el caso de que así sea.
             * 
             */

            // Declaración de Variables:

            int num1, num2;
 
            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            // Condicional para determinar el Mayor o si son Iguales:

            if(num1 > num2)
                Console.WriteLine($"El número {num1} es Mayor.");
            else if(num1 == num2)
                Console.WriteLine($"Son Iguales.");
            else
                Console.WriteLine($"El número {num2} es Mayor.");

            Console.ReadKey();

        }
    }
}
