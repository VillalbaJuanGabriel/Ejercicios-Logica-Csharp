using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 01:
             * 
             * Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
             * Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre 
             * por pantalla el monto total a pagar. Usar la función.
             * 
             */

            // Declaración de Variables;

            float precio, montoTotal;
            int cantidadVendida;

            // Ingreso de los Datos Correspondientes:

            Console.WriteLine("Ingrese el Precio del Artículo: ");
            precio = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Cantidad Vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            // Calculo del Monto Total con la Invocación de la Función Producto:

            montoTotal = Producto(precio, cantidadVendida);

            // Se Imprime el Monto Total por Pantalla:

            Console.WriteLine($"El monto total a pagar es de {montoTotal} pesos.");
            
            Console.ReadKey();
        }

        // Declaración de la Función:

        static float Producto(float n1, int n2)
        {
            float resultado = n1 * n2;
            return resultado;
        }

    }
}
