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
             * Hacer un programa que solicite el ingreso de dos números y luego calcular:
             * 
             *      a. La resta si el primero es mayor que el segundo.
             *      b. La suma si son iguales.
             *      c. El producto si el primero es menor.
             *      
             * Se deberá emitir un cartel por pantalla con el resultado correspondiente.
             * 
             */

            // Declaración de Variables:

            int num1, num2, resta, suma, producto;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            // Cálculos:

            resta = num1 - num2;
            suma = num1 + num2;
            producto = num1 * num2;

            // Condicional para Evaluar los Cálculos:

            if(num1 > num2) Console.WriteLine($"El resultado de la resta es: {resta}.");
            else if(num1 == num2) Console.WriteLine($"El resultado de la suma es: {suma}.");
            else Console.WriteLine($"El resultado del producto es: {producto}.");

            Console.ReadKey();

        }
    }
}
