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
             * Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
             * 
             */

            // Declaración de Variables:

            int num1, num2, num3, num4, menor;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el último número: ");
            num4 = int.Parse(Console.ReadLine());

            // Condicionales para determinar el número menor:

            if (num1 < num2)
                menor = num1;
            else
                menor = num2;

            if (num3 < menor)
                menor = num3;

            if (num4 < menor)
                menor = num4;

            // Se imprime el menor por pantalla:

            Console.WriteLine($"El número menor es: {menor}.");

            Console.ReadKey();

        }
    }
}
