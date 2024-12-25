using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Ejercicio 03:
             * 
             * Hacer un programa que permita ingresar el año actual y el año de la fecha de nacimiento 
             * de una persona y luego calcule y emita por pantalla su edad.
             * 
             */

            // Declaración de Variables:

            int añoActual, añoNacimiento, edad;

            // Ingreso de los Años correspondientes:

            Console.WriteLine("Ingrese el año actual: ");
            añoActual = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su año de nacimiento: ");
            añoNacimiento = int.Parse(Console.ReadLine());

            // Cálculo de la Edad:

            edad = añoActual - añoNacimiento;

            // Emisión de Edad por Pantalla:

            Console.WriteLine($"Tienes una edad de {edad} años.");

            Console.ReadKey();

        }
    }
}
