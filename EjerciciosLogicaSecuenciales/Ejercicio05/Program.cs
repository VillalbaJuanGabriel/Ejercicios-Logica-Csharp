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
             * Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión 
             * del 5% sobre el total facturado por cada empleado. 
             * Hacer un programa para ingresar el total facturado por un empleado y que luego calcule 
             * y emita por pantalla el sueldo total a cobrar por el mismo.
             * 
             */

            // Declaración de las Variables y Definición de Constantes:

            double totalFacturado, sueldoTotal;

            const double SUELDO_FIJO = 15000;
            const double COMISION = 0.05;

            // Ingreso del Total Facturado:

            Console.WriteLine("Ingrese el total facturado por el empleado: ");
            totalFacturado = double.Parse(Console.ReadLine());

            // Cálculo del Sueldo Total:

            sueldoTotal = SUELDO_FIJO + (totalFacturado * COMISION);

            // Emisión del Sueldo Total por Pantalla:

            Console.WriteLine($"El Sueldo Total es de {sueldoTotal} pesos.");

            Console.ReadKey();

        }
    }
}
