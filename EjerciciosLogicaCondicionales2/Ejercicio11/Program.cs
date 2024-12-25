using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 11:
             * 
             * Hacer un programa para ingresar tres números y luego mostrarlos ordenados de menor a mayor.
             * 
             */

            // Declaración de Variables:

            int num1, num2, num3, menor, medio, mayor;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el último número: ");
            num3 = int.Parse(Console.ReadLine());

            // Condicional para determinar el Número Menor:

            if (num1 < num2 && num1 < num3)
                menor = num1;
            else if (num2 < num1 && num2 < num3)
                menor = num2;
            else
                menor = num3;

            // Condicional para determinar el Número Medio:

            if ((num1 < num2 && num1 > num3) || (num1 > num2 && num1 < num3))
                medio = num1;
            else if ((num2 < num1 && num2 > num3) || (num2 > num1 && num2 < num3))
                medio = num2;
            else
                medio = num3;

            // Condicional para determinar el Número Mayor:

            if (num1 > num2 && num1 > num3)
                mayor = num1;
            else if (num2 > num1 && num2 > num3)
                mayor = num2;
            else
                mayor = num3;

            // Se imprimen los valores ordenados de menor a mayor por pantalla:

            Console.WriteLine("Los números ordenados de menor a mayor son: ");
            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(mayor);

            Console.ReadKey();

        }
    }
}
