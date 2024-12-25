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
             * Hacer un programa que solicite la edad de un grupo de personas. 
             * El programa deberá pedir edades hasta que se ingrese una edad menor a 18 años. 
             * Deberá mostrar por pantalla cuántas personas mayores se registraron.
             * 
             */

            // Declaración de Variables:

            int edad, contador;

            // Ingreso de las Edades:

            Console.WriteLine("Ingrese su Edad: ");
            edad = int.Parse(Console.ReadLine());

            contador = 0;

            // Ciclo While:

            while(edad >= 18)
            {
                contador++;

                Console.WriteLine("Ingrese su Edad: ");
                edad = int.Parse(Console.ReadLine());
            }

            // Se emite por pantalla el contador de edades:

            Console.WriteLine($"Cantidad de Personas Mayor a 18 años: {contador}.");

            Console.ReadKey();

        }
    }
}
