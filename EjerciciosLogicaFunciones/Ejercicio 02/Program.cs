using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 02:
             * 
             * Hacer una función llamada “mayor” que reciba dos números enteros 
             * y devuelva el mayor de ellos o cero si son iguales.
             * 
             */

            // Declaración de Variables:

            int num1, num2, mayor;

            // Ingreso de los Números: 

            Console.WriteLine("Ingrese un Número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro Número: ");
            num2 = int.Parse(Console.ReadLine());

            // Se Invoca la Función Mayor para buscar el Número Mayor o si son Iguales:

            mayor = Mayor(num1, num2);

            // Se Emite el Mayor o el Cero por Pantalla:

            Console.WriteLine($"Número: {mayor}.");

            Console.ReadKey();

        }

        // Declaración de la Función:

        static int Mayor(int n1, int n2)
        {
            if (n1 > n2) return n1;
            else if (n2 > n1) return n2;
            else return 0;
        }

    }
}
