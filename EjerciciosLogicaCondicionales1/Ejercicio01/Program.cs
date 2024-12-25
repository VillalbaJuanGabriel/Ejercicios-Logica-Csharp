using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 01:
             * 
             * Hacer un programa para ingresar un número y luego se emita por pantalla un
             * cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
             * 
             */

            // Declaración de Variables:

            int numero;
            string mayor;

            // Ingreso del Número:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // Operador Ternario para evaluar el número ingresado:

            mayor = (numero > 10) ? "Es mayor a 10." : "No es mayor a 10.";

            // Se emite la condición por pantalla:

            Console.WriteLine(mayor);

            Console.ReadKey();

        }
    }
}
