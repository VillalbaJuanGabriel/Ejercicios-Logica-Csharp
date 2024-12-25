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
             * Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la 
             * posición en la que fue encontrado cada uno de los mínimos.
             * 
             */

            // Declaración de Variables:

            int numero, menor, segundoMenor, posicion, posicionMenor, posicionSegundoMenor;

            // Ingreso de los Números:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // Se les asignan a las variables el mayor número posible para luego buscar los menores:

            menor = int.MaxValue;
            segundoMenor = int.MaxValue;

            // Se inicializan en cero las posiciones:

            posicion = 0;
            posicionMenor = 0;
            posicionSegundoMenor = 0;

            // Ciclo While:

            while (numero != 0)
            {
                // Se usa la variable posicion como iterador como auxiliar para las posiciones de los números menores:

                posicion++;

                // Condicional para buscar los menores y sus posiciones:

                if (numero < menor)
                {
                    segundoMenor = menor;
                    menor = numero;
                    posicionSegundoMenor = posicionMenor;
                    posicionMenor = posicion;
                }
                else
                {
                    if (numero < segundoMenor)
                    {
                        segundoMenor = numero;
                        posicionSegundoMenor = posicion;
                    }
                }

                // Se vuelven a pedir los Números:

                Console.WriteLine("Ingrese otro número: ");
                numero = int.Parse(Console.ReadLine());
            }

            // Se emiten por pantalla los menores y sus respectivas posiciones:

            Console.WriteLine($"Número Menor: {menor}.");
            Console.WriteLine($"Posición Menor: {posicionMenor}.");

            Console.WriteLine($"Segundo Menor: {segundoMenor}.");
            Console.WriteLine($"Posición Segundo Menor: {posicionSegundoMenor}.");

            Console.ReadKey();

        }
    }
}
