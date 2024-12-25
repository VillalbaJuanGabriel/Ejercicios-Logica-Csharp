using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Ejercicio 08:
             * 
             * Una importante cadena de delivery cuenta con una promoción por tiempo limitado en 
             * la que otorga un 15% de descuento sobre el total del valor de la compra realizada. 
             * Hacer un programa para solicitar el monto total y el mismo calcule y emita por pantalla 
             * el total a cobrar con el descuento aplicado.
             * 
             */

            // Declaración de Variables y Definición de Constantes:

            double montoTotal, totalACobrar;

            const double DESCUENTO = 0.15;

            // Ingreso del Monto:

            Console.WriteLine("Ingrese el Monto Total de la Compra: ");
            montoTotal = double.Parse(Console.ReadLine());

            // Cálculo del Monto Total a Cobrar:

            totalACobrar = montoTotal - (montoTotal * DESCUENTO);

            // Se emite el Monto Final por Pantalla:

            Console.WriteLine($"El monto final de su compra es de {totalACobrar} pesos.");

            Console.ReadKey();

        }
    }
}
