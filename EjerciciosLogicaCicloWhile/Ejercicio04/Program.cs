using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 04:
             * 
             * Hacer un programa que solicite dos números y luego muestre 
             * los números entre el menor y el mayor de ellos.
             * 
             */

            // Declaración de Variables:

            int num1, num2, menor, mayor;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            // Condicional para determinar el menor y el mayor:

            if(num1 > num2)
            {
                mayor = num1;
                menor = num2;
            } else
            {
                mayor = num2;
                menor = num1;
            }

            // Se incrementa el menor, para que al imprimirse, el mismo no se incluya:

            menor = menor + 1;

            Console.WriteLine("Los números existentes entre el Menor y el Mayor son: ");

            // Ciclo While para ciclar desde el menor + 1, hasta uno antes que el mayor:

            while (menor < mayor)
            {
                Console.WriteLine(menor);
                menor++;
            }

            Console.ReadKey();

        }
    }
}
