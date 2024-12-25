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
             * El negocio de desinfectante antes mencionado vende además detergente suelto, 
             * y los precios se aplican según la siguiente escala:
             * 
             *      a. 25 ARS por litro los primeros 50 litros.
             *      b. 20 ARS por litro si la venta es de 51 a 200 litros.
             *      c. 15 ARS por litro si la venta es de 201 a 500 litros.
             *      d. 10 ARS por litro si la venta es de más de 500 litros.
             *      
             * Además, si paga en efectivo, tiene un adicional del 10% sobre el importe final.
             * 
             * Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago 
             * (ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule 
             * y emita por pantalla el monto final a abonar por el cliente.
             * 
             */

            // Declaración de Variables:

            int litros, tipoPago;
            double monto;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese la Cantidad de Litros: ");
            litros = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Tipo de Pago: ");
            Console.WriteLine("1. Efectivo.");
            Console.WriteLine("0. Otro Medio de Pago.");
            tipoPago = int.Parse(Console.ReadLine());

            // Condicional para determinar los Precios:

            if (litros > 500) monto = litros * 10;
            else if (litros > 200) monto = litros * 15;
            else if (litros > 50) monto = litros * 20;
            else monto = litros * 25;

            // Condicional para determinar el Tipo de Pago:

            if (tipoPago == 1)
            {
                monto = monto + (monto * 0.10);
                Console.WriteLine($"El monto final. en efectivo, es ${monto} pesos.");
            } else
            {
                Console.WriteLine($"El monto final es ${monto} pesos.");
            }

            Console.ReadKey();

        }
    }
}
