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
             * Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
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

            Console.WriteLine("");
            Console.WriteLine("Los números Mayores a 100 son: ");

            // Condicional para mostrar los números mayores a 100:

            if(num1 > 100) Console.WriteLine(num1);

            if(num2 > 100) Console.WriteLine(num2);

            if(num3 > 100) Console.WriteLine(num3);

            if(num4 > 100) Console.WriteLine(num4);

            Console.ReadKey();

        }
    }
}
