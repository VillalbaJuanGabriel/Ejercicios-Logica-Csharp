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
             * Un importante negocio de desinfectante líquido realiza descuentos dependiendo 
             * de la cantidad de litros vendidos según la siguiente escala:
             *  
             *      a. Si vende menos de 100 litros, no hay descuento.
             *      b. Si vende entre 101 y 300 litros, el descuento es del 10%.
             *      c. Si vende entre 301 y 500 litros, el descuento es del 15%.
             *      d. Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
             *      
             *      Hacer un programa que solicite el ingreso del importe total de la venta y la
             *      cantidad de litros vendidos y calcule y emita el importe con el descuento aplicado.
             *      
             */

            // Declaración de Variables:

            double litrosVendidos, importeDeVenta, importeFinal;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese el importe de la venta: ");
            importeDeVenta = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
            litrosVendidos = double.Parse(Console.ReadLine());

            // Condicionales para determinar los Importes correspondientes:

            if (litrosVendidos > 500)
                importeFinal = importeDeVenta - (importeDeVenta * 0.25);
            else if (litrosVendidos > 300)
                importeFinal = importeDeVenta - (importeDeVenta * 0.15);
            else if (litrosVendidos > 100)
                importeFinal = importeDeVenta - (importeDeVenta * 0.10);
            else
                importeFinal = importeDeVenta;

            // Se emite el importe final por pantalla:

            Console.WriteLine($"El importe final es de ${importeFinal} pesos.");

            Console.ReadKey();

        }
    }
}
