using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 02:
             * 
             * Una compañía de electricidad necesita calcular anualmente el consumo que ha registrado 
             * cada uno de sus usuarios y el monto pagado por cada uno de ellos.
             * 
             * Para ello tiene un lote de registros por cada uno de los usuarios con los siguientes datos:
             * 
             *      • Zona (numérico entero).
             *      • Número de cliente (número de cuatro dígitos no correlativos).
             *      • Cantidad de kilovatios consumidos en el periodo.
             *      
             * El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro 
             * con zona igual a cero.
             * 
             * Se pide generar un listado con el siguiente formato:
             * 
             *      Zona: XX
             *      Cantidad de usuarios de la zona: XX
             *      Total facturado en la zona: XX
             *      
             *      Zona: XX
             *      Cantidad de usuarios de la zona: XX
             *      Total facturado en la zona: XX
             *      
             * El precio es escalonado según la siguiente escala:
             * 
             *      • $ 0.10 por kv por los primeros 100 kv de consumo.
             *      • $ 0.12 por kv por el consumo de 101 a 200 kvs.
             *      • $ 0.15 por kv por el consumo de 201 kvs en adelante.
             *      
             */

            // DECLARACIÓN DE VARIABLES:

            int zona, zonaActual, numCliente, cantKilovaltios, contadorUsuarios;
            double precio, montoFinal;
            

            // Ingreso de los Datos:

            Console.WriteLine("Ingrese el Número de Zona: ");
            zona = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Número de Cliente: ");
            numCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Cantidad de Kilovaltios Consumidos: ");
            cantKilovaltios = int.Parse(Console.ReadLine());

            // Ciclo While (Lote):

            while(zona != 0)
            {
                // Corte de Control con el Valor de la Zona:

                zonaActual = zona;

                // Contador de Usuarios:

                contadorUsuarios = 0;

                precio = montoFinal = 0;

                // Ciclo While (Sublote con Corte de Control):

                while(zona == zonaActual)
                {
                    contadorUsuarios++;

                    // Condicional para determinar los precios según el Consumo de Kilovaltios:

                    if (cantKilovaltios > 200) precio = 0.15;
                    else if (cantKilovaltios > 100) precio = 0.12;
                    else precio = 0.10;

                    montoFinal += precio;

                    // Se vuelven a pedir los Datos:

                    Console.WriteLine("Ingrese el Número de Zona: ");
                    zona = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Número de Cliente: ");
                    numCliente = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la Cantidad de Kilovaltios Consumidos: ");
                    cantKilovaltios = int.Parse(Console.ReadLine());
                }

                // Se Emiten los Resultados de cada Zona por pantalla: 

                Console.WriteLine($"Zona: {zonaActual}.");
                Console.WriteLine($"Cantidad de Usuarios de la Zona: {contadorUsuarios}.");
                Console.WriteLine($"Total Facturado en la Zona: ${montoFinal} pesos.");

            }

            Console.ReadKey();

        }
    }
}
