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
             * Una empresa registró las compras realizadas a sus distintos proveedores durante todo el año anterior. 
             * 
             * Para cadacompra se registraron los siguientes datos:
             * 
             *      • Número de proveedor (número de cuatro cifras no correlativo).
             *      • Día (1 a 31).
             *      • Mes (1 a 12).
             *      • Tipo de Factura (Responsable inscripto: "A",Consumidor Final: "B", o Monotributo: "C").
             *      • Número de Producto (número no correlativo).
             *      • Cantidad comprada.
             *      • Precio unitario del producto.
             *      
             * Este lote finaliza con un registro con número de proveedor igual a 0.
             * 
             * Los registros están agrupados por número de proveedor. En el lote anterior no aparecen registros 
             * de los proveedores a los que que no se les hayan realizado compras.
             * 
             * Se pide determinar e informar:
             * 
             *      a. El monto máximo registrado en una sola compra por cada proveedor y el número de proveedor al que se le compró.
             *      b. La inversión total de todo el año discriminada por tipo de factura.
             *      c. La compra con menor monto registrada durante el mes de Agosto junto al número de producto comprado.
             *      d. La cantidad de compras que se realizaron a cada proveedor.
             *      e. El número de producto con mayor cantidad comprada en una sola compra y en qué proveedor se compró.
             *      
             */

            // DECLARACIÓN DE VARIABLES:

            int numeroProveedor, dia, mes, numeroProducto, cantidadComprada, numeroProveedorActual;
            double precioUnitario, monto, montoMax;
            double acumuladorA, acumuladorB, acumuladorC, maxCantidadProveedor, contadorCompra, min, productoMin;
            char tipoFactura;
            bool bandera;
            int productoMax, numeroProveedorMax;

            // Inicialización de Variables:

            acumuladorA = acumuladorB = acumuladorC = maxCantidadProveedor = 0;
            bandera = false;
            min = productoMin = productoMax = numeroProveedorMax = 0;

            // Se ingresa el Número de Proveedor:

            Console.WriteLine("Ingrese el Número de Proveedor: ");
            numeroProveedor = int.Parse(Console.ReadLine());

            // Ciclo While (Lote):

            while(numeroProveedor != 0)
            {
                numeroProveedorActual = numeroProveedor;

                // Se Ingresa el resto de los Datos:

                Console.WriteLine("Ingrese el Día: ");
                dia = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Mes: ");
                mes = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Tipo de Factura: ");
                Console.WriteLine("'A' - Responsable Inscripto.");
                Console.WriteLine("'B' - Consumidor Final.");
                Console.WriteLine("'C' - Monotributo.");
                tipoFactura = char.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Número de Producto: ");
                numeroProducto = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la Cantidad Comprada: ");
                cantidadComprada = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Precio Unitario del Producto: ");
                precioUnitario = double.Parse(Console.ReadLine());

                montoMax = 0;
                contadorCompra = 0;

                // Ciclo While (Corte de Control):

                while(numeroProveedor == numeroProveedorActual)
                {
                    // Consigna A:

                    monto = cantidadComprada * precioUnitario;

                    if (monto > montoMax) montoMax = monto;

                    // Consigna B:

                    switch (tipoFactura)
                    {
                        case 'A': acumuladorA += monto; break;
                        case 'B': acumuladorB += monto; break;
                        case 'C': acumuladorC += monto; break;
                    }

                    // Consigna C:

                    if(mes == 8)
                    {
                        if(bandera == false)
                        {
                            min = monto;
                            productoMin = numeroProducto;
                            bandera = true;
                        }
                    } else
                    {
                        if(monto < min)
                        {
                            min = monto;
                            productoMin = numeroProducto;
                        }
                    }

                    // Consigna D:

                    contadorCompra++;

                    // Consigna E:

                    if(cantidadComprada > maxCantidadProveedor)
                    {
                        maxCantidadProveedor = cantidadComprada;
                        productoMax = numeroProducto;
                        numeroProveedorMax = numeroProveedor;
                    }

                    // Se vuelve a pedir el Número de Proveedor:

                    Console.WriteLine("Ingrese el Número de Proveedor: ");
                    numeroProveedor = int.Parse(Console.ReadLine());
                }

                // Se Emite por Pantalla la Consigna A:

                Console.WriteLine($"El monto máximo registrado en una sola compra por cada proveedor es: {montoMax}.");
                Console.WriteLine($"Y el número de proveedor al que se le compró es el N°{numeroProveedorActual}.");


                // Se Emite por Pantalla la Consigna D:

                Console.WriteLine($"La cantidad de compras que se realizaron a cada proveedor es: {contadorCompra}.");

            }

            // Se Emite por Pantalla la Consigna B:

            Console.WriteLine($"La inversión total de todo el año por el tipo de factura A es: {acumuladorA}.");
            Console.WriteLine($"La inversión total de todo el año por el tipo de factura B es: {acumuladorB}.");
            Console.WriteLine($"La inversión total de todo el año por el tipo de factura C es: {acumuladorC}.");

            // Se Emite por Pantalla la Consigna C:

            Console.WriteLine($"La compra con menor monto registrada durante el mes de Agosto fue: {min}.");
            Console.WriteLine($"Y su número de producto fué: {productoMin}.");

            // Se Emite por Pantalla la Consigna E:

            Console.WriteLine($"El número de producto {productoMax} representa la mayor cantidad comprada en una sola compra.");
            Console.WriteLine($"Y se compró al proveedor N°{numeroProveedorMax}.");

            Console.ReadKey();

        }
    }
}
