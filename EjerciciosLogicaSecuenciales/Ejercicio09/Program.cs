using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Ejercicio 09:
             * 
             * Una universidad desea conocer los porcentajes de mujeres y hombres en las carreras de ciencias exactas. 
             * Se solicita un programa para cargar la cantidad de mujeres y la cantidad de hombres 
             * y que el mismo calcule y emita por pantalla los porcentajes correspondientes.
             * 
             */

            // Declaración de las Variables:

            double cantidadMujeres, cantidadHombres, cantidadEstudiantes, porcentajeMujeres, porcentajeHombres;

            // Ingreso de las Cantidades de Mujeres y Hombres:

            Console.WriteLine("Ingrese la cantidad de Mujeres: ");
            cantidadMujeres = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de Hombres: ");
            cantidadHombres = double.Parse(Console.ReadLine());

            // Cálculo de la Cantidad de Estudiantes:

            cantidadEstudiantes = cantidadMujeres + cantidadHombres;

            // Cálculo de los Porcentajes correspondientes:

            porcentajeMujeres = cantidadMujeres * 100 / cantidadEstudiantes;
            porcentajeHombres = cantidadHombres * 100 / cantidadEstudiantes;

            // Se Emite por Pantalla los Porcentajes:

            Console.WriteLine($"Porcentaje de Mujeres: {porcentajeMujeres}%.");
            Console.WriteLine($"Porcentaje de Hombres: {porcentajeHombres}%.");

            Console.ReadKey();

        }
    }
}
