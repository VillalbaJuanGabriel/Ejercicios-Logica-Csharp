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
             * Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si 
             * son todos iguales entre sí, caso contrario, no emitir nada.
             * 
             */

            // Declaración de Variables:

            int num1, num2, num3, num4;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el último número: ");
            num4 = int.Parse(Console.ReadLine());

            // Condicional para determinar si todos los números son iguales entre sí:

            if(num1 == num2 && num2 == num3 && num3 == num4 && num4 == num1) Console.WriteLine("Son iguales entre sí.");
            else Console.WriteLine("No son iguales entre sí.");

            Console.ReadKey();

        }
    }
}
