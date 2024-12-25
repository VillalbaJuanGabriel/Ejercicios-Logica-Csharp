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
             * Una compañía de turismo aventura registró los paquetes vendidos durante la última temporada vacacional. 
             * 
             * Para cada venta se ingresó:
             * 
             *      • Número de paquete (4 dígitos no correlativos).
             *      • Cantidad de personas incluidas.
             *      • Precio por persona.
             *      • Horas totales de actividades.
             *      • Tipo de aventura (“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta. “C”, Canopy. 
             *        “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”, Parapente).
             *        
             * El lote se encuentra no ordenado y agrupado por tipo de aventura y corta con número de paquete cero. 
             * 
             * En el lote no se ingresan registros cuyo tipo de aventura no se haya vendido.
             * 
             * A partir de dichos datos, se solicita informar:
             * 
             *      a. La cantidad de paquetes vendidos de cada tipo de aventura..
             *      b. La cantidad total de personas que disfrutaron de las aventuras durante la temporada.
             *      c. El total recaudado por cada venta.
             *      d. La venta con mayor importe de cada tipo de aventura.
             *      e. El paquete con menos horas incurridlas y en qué tipo de actividad fue.
             *      
             */

            // DECLARACIÓN DE VARIABLES:

            int numeroPaquete, personas, horas, cantidadPaquetes, acumulacionPersonas, horasMinimas;
            double precio, total, ventaMayor;
            string tipoAventura, aventuraActual, tipoAventuraMin;

            ventaMayor = 0;
            acumulacionPersonas = 0;

            // Ingreso de los Datos:

            Console.WriteLine("Ingrese el Número de Paquete: ");
            numeroPaquete = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Cantidad de Personas: ");
            personas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Precio de la Aventura: ");
            precio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Cantidad de Horas: ");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Tipo de Aventura; ");
            Console.WriteLine("(“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta. “C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”, Parapente).");
            tipoAventura = Console.ReadLine();

            horasMinimas = horas;
            tipoAventuraMin = tipoAventura;

            // Ciclo While (Lote):

            while(numeroPaquete != 0)
            {
                aventuraActual = tipoAventura;
                cantidadPaquetes = 0;
               
                // Ciclo While (Sublote con Corte de Control):

                while(tipoAventura == aventuraActual)
                {
                    cantidadPaquetes++;

                    acumulacionPersonas += personas;

                    total = personas * precio;

                    Console.WriteLine($"Recaudado por Venta: {total} pesos.");

                    if (total > ventaMayor) ventaMayor = total;

                    if(horas < horasMinimas)
                    {
                        horasMinimas = horas;
                        tipoAventuraMin = tipoAventura;
                    }

                    // Se vuelven a Ingresar los Datos:

                    Console.WriteLine("Ingrese el Número de Paquete: ");
                    numeroPaquete = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la Cantidad de Personas: ");
                    personas = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Precio de la Aventura: ");
                    precio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la Cantidad de Horas: ");
                    horas = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Tipo de Aventura; ");
                    Console.WriteLine("(“M”, Montaña. “T”, Trekking. “R”, Rafting. “B”, Bicicleta. “C”, Canopy. “E”, Escalar. “K”, Sky. “S”, Snowboard. “J”, Jumping. “P”, Parapente).");
                    tipoAventura = Console.ReadLine();
                }

                // Se Emite por pantalla la Cantidad de Paquetes y la Recaudación Máxima:

                Console.WriteLine($"La cantidad de paquetes vendidos de cada tipo de aventura es: {cantidadPaquetes}.");
                Console.WriteLine($"La recaudación Máxima fue: {ventaMayor} pesos.");


            }

            // Se Emite por pantalla la cantidad Total de Personas y la Actividad menos concurrida:

            Console.WriteLine($"Cantidad Total de Personas: {acumulacionPersonas}.");
            Console.WriteLine($"Paquete con menos horas incurridas: {tipoAventuraMin}. Cantidad de Horas: {horasMinimas}hs.");

            Console.ReadKey();

        }
    }
}
