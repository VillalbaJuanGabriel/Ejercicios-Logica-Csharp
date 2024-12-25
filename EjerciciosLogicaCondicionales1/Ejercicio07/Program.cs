using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 07:
             * 
             * Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el mayor de ellos.
             * 
             */

            // Declaración de Variables:

            int num1, num2, num3, num4, mayor;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el último número: ");
            num4 = int.Parse(Console.ReadLine());

            // Condicionales para determinar el número mayor:

            if (num1 > num2)
                mayor = num1;
            else
                mayor = num2;

            if (num3 > mayor)
                mayor = num3;

            if (num4 > mayor)
                mayor = num4;

            // Se imprime el mayor por pantalla:

            Console.WriteLine($"El número mayor es: {mayor}.");

            Console.ReadKey();

        }
    }
}
