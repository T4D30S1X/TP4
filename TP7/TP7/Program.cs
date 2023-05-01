using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    /* Continuando el ejercicio anterior, se pedira una frase o palabra y se validara si la primera letra de la frase es igual a la 
      ultima letra de la frase. Se debera imprimir un mensaje q diga "CORRECTO" en caso contrario "INCORRECTO" */

    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            string letra, letra2;
            int longitud;


            Console.WriteLine("Ingrese una frase o palabra: ");
            palabra = Console.ReadLine();


            longitud =palabra.Length -1 ;
            letra = (palabra.Substring(0, 1));
            letra2 =(palabra.Substring(longitud));


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();

            if (letra==letra2)
             {
                Console.WriteLine("CORRECTO");

            }
            else
            {
                Console.WriteLine("INCORRECTO");
            }

            Console.ReadKey();
        }
    }
}














