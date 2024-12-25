using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 09:
             * 
             * Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
             * Para ello existe la siguiente escala de precios:
             * 
             *              i5 (1)   i7 (2)   i9 (3)
             *   8 RAM (1) USD 800  USD 900  USD 1200
             *  16 RAM (2) USD 900  USD 1000 USD 1400
             *  32 RAM (3) USD 1000 USD 1400 USD 2000
             * 
             * Además, el equipo viene con un disco que permite almacenar 500 GB de
             * información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo adicional de USD 300.
             * 
             * Hacer un programa que solicite la opción de procesador, la opción de memoria RAM, 
             * y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule 
             * y emita por pantalla el monto de la máquina seleccionada.
             * 
             */

            // Declaración de Variables:

            int procesador, ram, extensionDisco;
            double precio;

            precio = 0;

            // Ingreso de los Datos:

            Console.WriteLine("Ingrese la Opción de Procesador: ");
            Console.WriteLine("1. i5.");
            Console.WriteLine("2. i7.");
            Console.WriteLine("3. i9.");
            procesador = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Opción de Memoria RAM: ");
            Console.WriteLine("1. 8GB.");
            Console.WriteLine("2. 16GB.");
            Console.WriteLine("3. 32GB.");
            ram = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Extiende Disco?");
            Console.WriteLine("1. Afirmativo.");
            Console.WriteLine("0. Negativo");
            extensionDisco = int.Parse(Console.ReadLine());

            // Condicionales Anidados entre Switch e IF para determinar los Precios según las Opciones elegidas:

            switch (procesador)
            {
                case 1:
                    if (ram == 1) precio = 800;
                    else if (ram == 2) precio = 900;
                    else if (ram == 3) precio = 1000;
                    else Console.WriteLine("Opción Inválida de Memoria RAM.");
                    break;

                case 2:
                    if (ram == 1) precio = 900;
                    else if (ram == 2) precio = 1000;
                    else if (ram == 3) precio = 1400;
                    else Console.WriteLine("Opción Inválida de Memoria RAM.");
                    break;

                case 3:
                    if (ram == 1) precio = 1200;
                    else if (ram == 2) precio = 1400;
                    else if (ram == 3) precio = 2000;
                    else Console.WriteLine("Opción Inválida de Memoria RAM.");
                    break;

                default:
                    Console.WriteLine("Opción Inválida de Procesador.");
                    break;
            }

            // Condicional para determinar si se Extiende Disco o no:

            if(extensionDisco == 1)
            {
                precio += 300;
                Console.WriteLine($"El Precio Final, con Extensión de Disco, es de ${precio} Dólares.");
            } else
            {
                Console.WriteLine($"El Precio Final es de ${precio} Dólares.");
            }

            Console.ReadKey();

        }
    }
}
