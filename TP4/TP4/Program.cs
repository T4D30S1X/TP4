using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    /* Realizar un programa q pida una frase, y si es de 4 caracteres de largo, el programa concatenara un signo de exclamasion al final 
      y si no lo es, el programa lo concatenara un signo de "¿" . El programa mostrara al final la frase final. */

    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            int numPalabras = 0;

            Console.WriteLine("Ingrese una frase o una palabra de 4 caracteres");
            palabra = Console.ReadLine();

            numPalabras = palabra.Length;

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();


            if (numPalabras == 4)
            {
                Console.WriteLine("¡"+palabra+"!");

            }
            else
            {
                Console.WriteLine("¿"+palabra+"?");
            }

            Console.ReadKey();
            
        }
    }
}
