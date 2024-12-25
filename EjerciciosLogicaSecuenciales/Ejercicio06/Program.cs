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
             * Hacer un programa para ingresar por teclado las tres notas de exámenes de un 
             * alumno y luego calcule y emita por pantalla el promedio final.
             * 
             */

            // Declaración de Variables:

            double notaUno, notaDos, notaTres, promedioFinal;

            // Ingreso de las Notas:

            Console.WriteLine("Ingrese la primer nota: ");
            notaUno = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota: ");
            notaDos = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la terer nota: ");
            notaTres = double.Parse(Console.ReadLine());

            // Cálculo del Promedio Final:

            promedioFinal = (notaUno + notaDos + notaTres) / 3;

            // Emisión del Promedio Final por Pantalla:

            Console.WriteLine($"El Promedio Final del alumno es: {promedioFinal}.");

            Console.ReadKey();

        }
    }
}
