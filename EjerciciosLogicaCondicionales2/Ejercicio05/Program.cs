using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 05:
             * 
             * Hacer un programa que solicite el ingreso de las notas del primer parcial y del 
             * segundo parcial de una alumna de programación. 
             * 
             * El programa deberá analizar las notas y emitir la situación de la alumna según la siguiente escala:
             * 
             *      a. Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
             *      b. Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales (se
             *         aprueba con 6 o más), emitir “rinde examen final”.
             *      c. Si tiene menos de 6 en alguno de los dos parciales, emitir “debe recuperar”.
             *      
             * El programa debe emitir solo un cartel, el que corresponda.
             * 
             */

            // Declaración de Variables:

            double notaUno, notaDos;

            // Ingreso de las Notas:

            Console.WriteLine("Ingrese la nota del Primer Parcial: ");
            notaUno = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Segundo Parcial: ");
            notaDos = double.Parse(Console.ReadLine());

            // Condicionales para determinar la Condición de la Alumna:

            if(notaUno >= 8 && notaDos >= 8)
                Console.WriteLine("Aprobación Directa.");
            else if(notaUno >= 6 && notaDos >= 6)
                Console.WriteLine("Rinde Examen Final.");
            else
                Console.WriteLine("Debe Recuperar.");

            Console.ReadKey();

        }
    }
}
