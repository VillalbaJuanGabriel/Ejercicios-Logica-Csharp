using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Ejercicio 10:
             * 
             * Hacer un programa que permita ingresar por teclado dos números y que luego muestre por pantalla 
             * la suma, la resta, la multiplicación y la división de dichos números. 
             * Se deben mostrar cuatro resultados en pantalla. 
             * Los números deben ser solicitados una única vez.
             * 
             */

            // Declaración de Variables:

            double num1, num2, suma, resta, multiplicacion, division;

            // Ingreso de los Dos Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = double.Parse(Console.ReadLine());

            // Cálculos de las distintas Operaciones Aritméticas:

            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = num1 / num2;

            // Emisión por Pantalla de los Resultados:

            Console.WriteLine($"Resultado de la Suma: {suma}.");
            Console.WriteLine($"Resultado de la Resta: {resta}.");
            Console.WriteLine($"Resultado de la Multiplicación: {multiplicacion}.");
            Console.WriteLine($"Resultado de la División: {division}.");

            Console.ReadKey();

        }
    }
}
