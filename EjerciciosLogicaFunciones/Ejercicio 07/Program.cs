using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 07:
             * 
             * Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
             * que reciba un número por valor y una variable por referencia. 
             * Que analice el número y escriba variable recibida por referencia con:
             *      a. 1 si el número es positivo.
             *      b. -1 si el número es negativo.
             *      c. 0 si el número es cero.
             *      
             * Hacer un programa main que permita ingresar 100 números y emitir por pantalla 
             * cuántos son positivos, cuántos negativos y cuántos cero.
             * 
             */

            // Declaración de Variables:

            int numero, bandera, positivos, negativos, ceros;
            
            bandera = 0;
            positivos = negativos = ceros = 0;


            // Ciclo For para Ingresar los 100 Números:

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un Número: ");
                numero = int.Parse(Console.ReadLine());

                // Invocación de la Función PositivoNegativoCero:

                PositivoNegativoCero(numero, ref bandera);

                if (bandera > 0) positivos++;
                else if (bandera < 0) negativos++;
                else ceros++;
            }

            // Se Emite por Pantalla la Cantidad de Positivos, Negativos, Ceros:

            Console.WriteLine($"Cantidad Positivos: {positivos}.");
            Console.WriteLine($"Cantidad Negativos: {negativos}.");
            Console.WriteLine($"Cantidad de Ceros: {ceros}.");

            Console.ReadKey();

        }

        // Declaración de la Función:

        static void PositivoNegativoCero(int numero, ref int variable)
        {
            if (numero > 0) variable = 1;
            else if (numero < 0) variable = -1;
            else variable = 0;
        }

    }
}
