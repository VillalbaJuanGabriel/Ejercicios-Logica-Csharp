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
             * Se dispone de una lista de 10 grupos de números enteros separados entre ellos por ceros. 
             * 
             * Se pide determinar e informar:
             * 
             *      a. El número de grupo con mayor porcentaje de números impares positivos respecto al total de 
             *         números que forman el grupo.
             *         
             *      b. Para cada grupo, el último número primo y en qué orden apareció en ese grupo. 
             *         Si en un grupo no hubiera números primos, informarlo con un cartel aclaratorio.
             *         
             *      c. Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
             *      
             */

            // DECLARACIÓN DE VARIABLES:

            int numero; // Variable Principal.

            int contadorImpares, contadorNumeros, porcentaje, porcentajeMax, grupoMax; // Variables de la Consigna A.

            contadorNumeros = porcentajeMax = 0;

            int contador, ordenPrimo, primo, posicionPrimo; // Variables de la Consigna B.
            grupoMax = 0;

            // Variables de la Consigna C:

            int mayor, contadorOrdenados;
            bool bandera;

            bandera = false;
            contadorOrdenados = 0;


            // Ciclo For (Lote):

            for (int i = 0; i < 5; i++)
            {
                // Ingreso de Números:

                Console.WriteLine("Ingrese un Número: ");
                numero = int.Parse(Console.ReadLine());

                contadorImpares = contadorNumeros = 0; // Inicialización de Variables de la Consigna A.

                ordenPrimo = posicionPrimo = primo = 0; // Inicialización de Variables de la Consigna B.

                mayor = numero; // Inicialización de Variables de la Consigna C.

                // Ciclo While (Sublote):

                while (numero != 0)
                {
                    // CONSIGNA A:

                    contadorNumeros++;

                    if (numero % 2 != 0 && numero > 0) contadorImpares++;


                    // CONSIGNA B:

                    contador = 0;
                    ordenPrimo++;

                    // Ciclo For (Sublote del While, para el Número Primo):

                    for(int y = 1; y <= numero; y++)
                    {
                        if (numero % y == 0) contador++;
                    }

                    if(contador == 2)
                    {
                        primo = numero;
                        posicionPrimo = ordenPrimo;
                    }

                    // CONSIGNA C:

                    if (numero > mayor) bandera = true;

                    mayor = numero;

                    // Se vuelven a pedir los Números:

                    Console.WriteLine("Ingrese otro Número: ");
                    numero = int.Parse(Console.ReadLine());

                }

                // PORCENTAJES DE LA CONSIGNA A:

                if(contadorNumeros > 0)
                {

                    porcentaje = contadorImpares * 100 / contadorNumeros;

                    if (porcentaje > porcentajeMax)
                    {
                        porcentajeMax = porcentaje;
                        grupoMax = i + 1;

                    }
                }


                // CONDICIONAL DE PRIMOS DE LA CONSIGNA B:
                // Emisión del Resultado de la Consigna B:

                if (primo != 0)
                    Console.WriteLine($"El último primo ingresado es: {primo} y fue ingresado en la posición: {posicionPrimo}.");
                else
                    Console.WriteLine("No se han ingresado números primos.");

                // CONDICIONAL PARA CONTAR LOS GRUPOS CON LOS NÚMEROS ORDENADOS DE MENOR A MAYOR DE LA CONSIGNA C:

                if (!bandera) contadorOrdenados++;

                bandera = false; // Se Reinicia la Bandera para el Siguiente Grupo.

            }

            // Se Emite por Pantalla el Resultado de la Consigna A:

            Console.WriteLine($"El grupo con mayor porcentaje de Impares positivos es el Grupo N°{grupoMax}.");

            // Se Emite por Pantalla el Resultado de la Consigna C:

            Console.WriteLine($"La cantidad de grupos con los números ordenados de mayor a menor son: {contadorOrdenados} grupos.");

            Console.ReadKey();

        }
    }
}
