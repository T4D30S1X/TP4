using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    /* Realizar un programa q pida una frase y valide si la primera letra es una "a", si si lo es se debe imprimir un mensaje de 
     "CORRECTO" en la pantalla, en caso contrario escribir "Incorrecto" */

    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            char letra;


            Console.WriteLine("Ingrese una frase o palabra");
            palabra = Console.ReadLine();


            letra = char.Parse( palabra.Substring(0,1));

            

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();

            if (letra=='a')
            {
                Console.WriteLine("CORRECTO");
            } else
            {
                Console.WriteLine("INCORRECTO");
            }

            Console.ReadKey();

        }
    }
}
