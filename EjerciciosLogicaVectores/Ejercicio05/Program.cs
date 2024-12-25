using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 05:
             * 
             * Hacer un programa que solicite una serie de valores de tipo char (caracteres).
             * Se entiende por carácter a cada elemento que se obtiene de presionar una tecla. 
             * 
             * Por ejemplo el valor “25” tiene dos caracteres (si quisiéramos guardarlo en variables enteras 
             * nos alcanza con una, pero si queremos guardarlo en variables char, necesitaremos dos); 
             * la frase “maxi programa” tiene 13 (se incluye el espacio como un carácter).
             * 
             * La cantidad de valores será como máximo 50, pero el programa puede cortar antes si se ingresa el carácter “.” (punto).
             * Una vez cargado el vector de char, recorrerlo y reemplazar todas las apariciones de la letra “a” por la letra “e”.
             * 
             * Por ejemplo:
             * 
             *      Vector char original: “Hola muchachada cómo están”.
             *      Vector char modificado: “Hole muchechede cómo esten”
             *      
             *      Finalmente, mostrar el resultado en pantalla.
             *      Nota: necesitaremos un vector char de 50, pero no lo cargaremos con un For.
             * 
             */

            // Declaración de Variables:

            char letra;
            int i;
            i = 0;

            // Declaración del Vector: 

            char[] vectorLetra = new char[50];

            Console.WriteLine("Ingrese una Letra: ");
            letra = char.Parse(Console.ReadLine());
            
            // Ciclo para Cargar las Letras:

            while(letra != '.' && i < 50)
            {
                vectorLetra[i] = letra;

                Console.WriteLine("Ingrese una Letra: ");
                letra = char.Parse(Console.ReadLine());

                i++;
            }

            // Ciclo para Cambiar la letra A por la B:

            for(int x = 0; x < 50; x++)
            {
                if (vectorLetra[x] == 'a') vectorLetra[x] = 'e';
            }

            i = 0;

            // Ciclo para mostrar las Letras cambiadas:

            while (vectorLetra[i] != '.' && i < 50)
            {
                Console.Write(vectorLetra[i]);
                i++;
            }

            Console.ReadKey();

        }
    }
}
