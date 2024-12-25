using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Ejercicio 04:
             * 
             * Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades 
             * y la velocidad promedio de un vehículo. 
             * Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro 
             * teniendo en cuenta los datos ingresados.
             * 
             */

            // Declaración de Variables:

            double kilometros, velocidad, tiempoAproxHoras, tiempoAproxMinutos;

            // Ingreso de los Datos correspondientes:

            Console.WriteLine("Ingrese la cantidad de kilometros existentes entre ciudades: ");
            kilometros = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad de su vehículo expresados en km/h: ");
            velocidad = double.Parse(Console.ReadLine());

            // Cálculo del Tiempo Aproximado del Viaje:

            tiempoAproxHoras = kilometros / velocidad;
            tiempoAproxMinutos = kilometros % velocidad;

            // Se emite por Pantalla el Tiempo Aproximado expresado en Horas y Minutos:

            Console.WriteLine($"El tiempo aproximado del viaje es de {tiempoAproxHoras.ToString("0")} Horas y {tiempoAproxMinutos} Minutos.");

            Console.ReadKey();

        }
    }
}
