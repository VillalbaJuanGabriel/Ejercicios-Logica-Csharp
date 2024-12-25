using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 12:
             * 
             * Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si 
             * la suma de los dos primeros es mayor al producto del segundo con el tercero.
             * 
             */

            // Declaración de Variables:

            int num1, num2, num3, suma, producto;
            string calculoMayor;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el último número: ");
            num3 = int.Parse(Console.ReadLine());

            // Cálculos correspondientes:

            suma = num1 + num2;
            producto = num2 * num3;

            // Condicional para determinar que Cálculo es mayor:

            calculoMayor = (suma > producto) ? "La Suma es Mayor que el Producto." : "la Suma NO es Mayor que el Producto.";

            // Se imprime el resultado por pantalla:

            Console.WriteLine(calculoMayor);

            Console.ReadKey();

        }
    }
}
