using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 12:
             * 
             * Hacer un programa para ingresar un valor que estará expresado en minutos. 
             * Si los minutos superan los 60, pasar el valor a horas, de lo contrario dejarlo en minutos. 
             * Mostrar el resultado en pantalla aclarando si se muestran minutos u horas.
             * 
             */

            // Declaración de Variables:

            int minutos, minutosRestantes, horas;

            // Ingreso de los Minutos:

            Console.WriteLine("Ingrese la cantidad de minutos: ");
            minutos = int.Parse(Console.ReadLine());

            if(minutos > 60)
            {
                horas = minutos / 60;
                minutosRestantes = minutos % 60;
                Console.WriteLine($"Cantidad de Horas: {horas}hs.");
                Console.WriteLine($"Minutos Restantes: {minutosRestantes}mins.");
            } else
            {
                Console.WriteLine($"Cantidad de Minutos: {minutos}mins.");
            }

            Console.ReadKey();

        }
    }
}
