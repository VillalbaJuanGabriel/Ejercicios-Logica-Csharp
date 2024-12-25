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
             * Hacer un programa para ingresar por teclado los metros cuadrados totales de un predio y 
             * los metros cuadrados cubiertos; luego calcular y mostrar por pantalla el porcentaje de 
             * metros cuadrados cubiertos y el porcentaje de metros cuadrados descubiertos.
             * 
             */

            // Declaración de Variables:

            double metrosTotales, metrosCubiertos, metrosDescubiertos, porcentajeCubiertos, porcentajeDescubiertos;

            // Ingreso de los Metros Correspondientes:

            Console.WriteLine("Ingrese los metros cuadrados totales: ");
            metrosTotales = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los metros cuadrados cubiertos: ");
            metrosCubiertos = double.Parse(Console.ReadLine());

            // Se determina los metros cuadrados descubiertos:

            metrosDescubiertos = metrosTotales - metrosCubiertos;

            // Cálculo de los Porcentajes correspondientes:

            porcentajeCubiertos = metrosCubiertos * 100 / metrosTotales;
            porcentajeDescubiertos = metrosDescubiertos * 100 / metrosTotales;

            // Se Emiten los Porcentajes por Pantalla:

            Console.WriteLine($"Porcentaje de los Metros Cubiertos: {porcentajeCubiertos}%.");
            Console.WriteLine($"Porcentaje de los Metros Descubiertos: {porcentajeDescubiertos}%.");

            Console.ReadKey();

        }
    }
}
