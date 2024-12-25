using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 06:
             * 
             * Hacer una función que se llame “sumaResta” que reciba dos números y que devuelva la suma y 
             * la resta del primer número con el segundo.
             * 
             */

            // Declaración de Variables:

            int num1, num2, suma;

            // Ingreso de los Números: 

            Console.WriteLine("Ingrese un Número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro Número: ");
            num2 = int.Parse(Console.ReadLine());

            // Invocación de la Función SumaResta:

            suma = SumaResta(num1, ref num2);

            // Se Emiten los Resultados por Pantalla:

            Console.WriteLine($"Resultado Suma: {suma}.");
            Console.WriteLine($"Resultado Resta: {num2}.");

            Console.ReadKey();

        }

        // Declaración de la Función:

        static int SumaResta(int n1, ref int n2)
        {
            int suma = n1 + n2;
            n2 = n1 - n2;

            return suma;
        }

    }
}
