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
             * Una casa de video juegos otorga un descuento dependiendo del importe de la 
             * compra realizada según los siguientes valores:
             * 
             *      • Si el importe es menor a ARS 1000, no hay descuento.
             *      • Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
             *      • Si el importe es ARS 5000 o más, aplica un descuento del 18%.
             *      
             * Hacer un programa para ingresar un importe de venta y luego muestre por
             * pantalla el importe final con el descuento que corresponda.
             * 
             */

            // Declaración de Variables:

            double importe, importeFinal;

            // Ingreso del Importe:

            Console.WriteLine("Ingrese el Importe de Venta: ");
            importe = double.Parse(Console.ReadLine());

            // Condicional para determinar los Importes correspondientes:

            if (importe >= 5000)
                importeFinal = importe - (importe * 0.18);
            else if (importe >= 1000)
                importeFinal = importe - (importe * 0.10);
            else
                importeFinal = importe;

            // Se emite el importe final por pantalla:

            Console.WriteLine($"Importe Final: ${importeFinal} pesos.");

            Console.ReadKey();

        }
    }
}
