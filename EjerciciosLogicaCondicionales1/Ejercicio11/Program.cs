using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 11:
             * 
             * Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuántos son menores a 100.
             * 
             */

            // Declaración de Variables:

            int num1, num2, num3, num4, contador;

            contador = 0;

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

            // Condicional para contar los números menores a 100:

            if (num1 < 100) contador++;

            if (num2 < 100) contador++;

            if (num3 < 100) contador++;

            if (num4 < 100) contador++;

            // Se imprime la cantidad de número menores a 100:

            Console.WriteLine($"La cantidad de números menores a 100 son: {contador}.");

            Console.ReadKey();

        }
    }
}
