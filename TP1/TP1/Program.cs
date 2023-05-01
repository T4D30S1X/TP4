using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    /* Realiza un programa que sólo permita introducir los caracteres ‘S’ y ‘N’. Si el usuario ingresa alguno de
esos dos caracteres se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en caso
contrario, se deberá imprimir “INCORRECTO”. */

    internal class Program
    {
        static void Main(string[] args)
        {
            char n;

            Console.WriteLine("Ingrese uno de los siguientes caracteres: 'S' o 'N'");
            n=char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            if (n == 'S' || n == 'N') 
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
