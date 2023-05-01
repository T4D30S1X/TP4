using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /* Realizar un programa que pida introducir solo frases o palabras de 6 caracteres. Si el usuario ingresa una
frase o palabra de 6 caracteres se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en
caso contrario, se deberá imprimir “INCORRECTO”. */

    internal class Program
    {
        static void Main(string[] args)
        {
            string pa;

            int numPalabras = 0;

            Console.WriteLine("Ingrese una frase o una palabra de 6 caracteres");
            pa = Console.ReadLine();

            numPalabras = pa.Length;

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();


            if (numPalabras == 6) 
            {
                Console.WriteLine("CORRECTO");

            }
            else
            {
                Console.WriteLine("INCORRECTO");
            }

            Console.ReadKey ();
;        }
    }
}
