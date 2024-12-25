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
             * Hacer un programa para ingresar 4 números. Luego analizar e informar por 
             * pantalla si los mismos se encuentran ordenados de forma decreciente.
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

            // Condicional para determinar la situación de los números: 

            if(num1 > num2 && num2 > num3 && num3 > num4) Console.WriteLine("Ordenados de Forma Decreciente.");
            else Console.WriteLine("No Ordenados de Forma Decreciente.");

            Console.ReadKey();

        }
    }
}
