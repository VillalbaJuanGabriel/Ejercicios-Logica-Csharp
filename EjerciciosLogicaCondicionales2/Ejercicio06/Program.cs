using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 06:
             * 
             * Hacer un programa para ingresar por teclado la longitud de los tres lados de un 
             * triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo de triángulo corresponde:
             * 
             *      a. Equilátero: cuando los tres lados sean iguales.
             *      b. Isósceles: cuando dos de los tres lados sean iguales.
             *      c. Escaleno: cuando todos los lados sean distintos.
             *      
             */

            // Declaración de Variables:

            int ladoA, ladoB, ladoC;

            // Ingreso de los Lados:

            Console.WriteLine("Ingrese el Lado A: ");
            ladoA = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Lado B: ");
            ladoB = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Lado C: ");
            ladoC = int.Parse(Console.ReadLine());

            // Condicional para determinar el Tipo de Triángulo:

            if(ladoA == ladoB && ladoB == ladoC && ladoC == ladoA) Console.WriteLine("Equilátero.");
            else if(ladoA != ladoB && ladoB != ladoC && ladoC != ladoA) Console.WriteLine("Escaleno.");
            else Console.WriteLine("Isósceles.");

            Console.ReadKey();

        }
    }
}
