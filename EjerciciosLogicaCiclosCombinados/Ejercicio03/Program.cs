using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 03:
             * 
             * Hacer un programa para ingresar los valores de los pesos de distintas encomiendas 
             * que se deben enviar a distintos clientes y que finaliza cuando se ingresa un peso negativo. 
             * 
             * Se deben agrupar las encomiendas en camiones que pueden transportar hasta 200 kilos en total.
             * 
             * Por ejemplo:
             * 
             *      10, 20, 140.  70, 100.  40, 10, 50, 80.  90, 30, 40.  50, -10.
             *      Camión 1.     Camión 2  Camión 3         Camión 4     Camión 5
             *      
             * Se pide determinar e informar:
             * 
             *      a. El número de camión y peso total de encomiendas (Camión 1: 170kg, Camión 2: 170kg, etc.).
             *      b. El número de camión que transporta mayor cantidad de encomiendas 
             *         (en el ejemplo anterior sería el camión 3 con 4 encomiendas).
             *      c. La cantidad de camiones que se terminaron cargando.
             * 
             */

            // DECLARACIÓN DE VARIABLES:

            double peso, pesoTotal;
            int camion, camionMax, encomiendas, maxEncomiendas;

            camion = 0;
            camionMax = 0;
            maxEncomiendas = 0;

            // Ingreso del Peso:

            Console.WriteLine("Ingrese el Peso de Encomienda: ");
            peso = double.Parse(Console.ReadLine());

            // Ciclo While (Lote):

            while(peso >= 0 && peso <= 200)
            {
                pesoTotal = 0;
                encomiendas = 0;

                camion++;

                // Ciclo While (Sublote):

                while(peso + pesoTotal <= 200 && peso > 0)
                {

                    pesoTotal += peso;

                    encomiendas++;

                    Console.WriteLine("Ingrese el Peso de Encomienda: ");
                    peso = double.Parse(Console.ReadLine());


                }

                // Se Imprime por pantalla cada Camión con su Peso correspondiente:

                Console.WriteLine($"Camión N°{camion}: Transporta {pesoTotal}Kgs.");

                if(encomiendas > maxEncomiendas)
                {
                    maxEncomiendas = encomiendas;
                    camionMax = camion;

                }

            }

            // Se Imprime por pantalla el Número de Camion que trasporta la mayor cantidad de encomiendas:

            Console.WriteLine($"El Camión N°{camionMax}, Transporta {maxEncomiendas} Encomiendas.");
            Console.WriteLine("Es el Camión que mayor cantidad de encomiendas transporta.");

            // Se Imprime por pantalla la cantidad de Camiones que se cargaron:

            Console.WriteLine($"La cantidad de camiones que se terminan cargando es: {camion} Camiones.");

            Console.ReadKey();

        }
    }
}
