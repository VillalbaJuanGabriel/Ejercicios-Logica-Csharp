using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 07:
             * 
             * Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
             *      • Número de artículo (1 a 15).
             *      • Cantidad vendida.
             *      
             * Puede haber varios registros para el mismo artículo y el último se indica número de artículo igual a cero.
             * 
             * Se pide determinar e informar:
             *      a. El número de artículo que más se vendió en total.
             *      b. Los números de artículos que no registraron ventas.
             *      c. La cantidad de unidades vendidas para el artículo número 10.
             *      
             * Nota: tener en cuenta el concepto de “registro” y el planteo de estructura principal separado de consignas 
             * (ver videos de ciclos combinados y ejercicios resueltos de ciclos combinados).
             * 
             */

            // Declaración de Variables:
            int numeroArticulo, cantidadVendida, mayor, posicionArticulo;

            // Declaración del Vector: 

            int[] vectorAcumulador = new int[15];

            // Ciclo For para crear un Acumulador para los 15 Números de Articulos:

            for(int i = 0; i < 15; i++)
            {
                vectorAcumulador[i] = 0;
            }

            // Ingreso de los Datos:

            Console.WriteLine("Ingrese el Número de Articulo: ");
            numeroArticulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Cantidad Vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            // Ciclo While para Sumar la Cantidades Vendidas:

            while(numeroArticulo != 0)
            {
                vectorAcumulador[numeroArticulo - 1] += cantidadVendida;

                Console.WriteLine("Ingrese el Número de Articulo: ");
                numeroArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la Cantidad Vendida: ");
                cantidadVendida = int.Parse(Console.ReadLine());
            }

            posicionArticulo = 0;

            // Ciclo For para buscar el Número de Articulo que más Vendió:

            for(int i = 0; i < 15; i++)
            {
                mayor = vectorAcumulador[i];

                if (vectorAcumulador[i] > mayor)
                {
                    mayor = vectorAcumulador[i];
                    posicionArticulo = i + 1;
                }
            }

            // Se Imprime por pantalla los Números de Articulos que no Registraron Ventas:

            Console.WriteLine("Los números de artículos que no registraron ventas son: ");

            for(int i = 0; i < 15; i++)
            {
                if (vectorAcumulador[i] == 0) Console.WriteLine($"N°{i+1}.");
            }

            // Se Emite por pantalla el Número de Artículo que más vendió:

            Console.WriteLine($"El número de artículo que más se vendió en total es el N°{posicionArticulo}.");

            // Se Emite por pantalla la Cantidad de Unidades Vendidas del N° 10:

            Console.WriteLine($"La cantidad de unidades vendidas en el N° de Producto 10 es: {vectorAcumulador[9]}.");

            Console.ReadKey();

        }
    }
}
