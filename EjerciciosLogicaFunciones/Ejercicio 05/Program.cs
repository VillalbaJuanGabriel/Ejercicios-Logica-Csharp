using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 05:
             * 
             * Hacer una función llamada “pagos” que reciba un monto (float) y una cantidad de pagos (entero) 
             * y devuelva el monto de cada pago. 
             * Hacer un programa para ingresar 10 ventas. 
             * Para cada venta se conoce el monto y la cantidad de pagos.
             * El programa deberá mostrar la cantidad de pagos y el monto del pago para cada una de las ventas.
             * 
             */

            // Declaración de Variables:

            float monto, montoCantidad;
            int cantidad;

            // Ciclo For para Ingresar Monto y Cantidad:

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el Monto: ");
                monto = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la Cantidad de Pagos: ");
                cantidad = int.Parse(Console.ReadLine());

                // Se Invoca la Función Pagos:

                Pagos(monto, cantidad);

                // Se Emite por Pantalla Monto y Cantidad:

                Console.WriteLine($"Monto: {monto} pesos.");
                Console.WriteLine($"Cantidad de Pagos: {cantidad}.");
            }

            Console.ReadKey();

        }

        // Declaración de la Función: 

        static float Pagos(float monto, int cantidad)
        {
            float resultado = monto / cantidad;
            return resultado;
        }

    }
}
