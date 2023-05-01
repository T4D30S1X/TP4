using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    /* Realizar un programa que pida un número y determine si ese número es par o impar. Mostrar en pantalla
un mensaje que indique si el número es par o impar. (para que un número sea par, se debe dividir entre dos
y su resto debe ser igual a 0). */

    internal class Program
    {
        static void Main(string[] args)
        {
            int n, resto;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            
            resto = (int)Math.IEEERemainder(n, 2);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine();

            if (resto==0)
            {
                Console.WriteLine("El numero " + n + " es par");

            } else
            {
                Console.WriteLine("El numero " + n + " no es par");
            } 

            Console.ReadKey();
        }
    }
}
