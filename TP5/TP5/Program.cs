using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    /* Realizar un programa q pida 3 notas y valide si esas notas estan entre 1 y 10, si lo estan el debe poner en verdadero una variable de tipo 
      logico y si no ponerlo en falso. El programa debe decir si las 3 notas son correctas usando la variable de tipo logicas. */

    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            bool aux=false;

            Console.WriteLine("Ingrese la primera nota ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota ");
            nota3 = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();


            if (nota1 <= 10) 
            {
                aux = true;
                Console.WriteLine("La nota " + nota1 + " es " + aux);

            }
            else
            {
                aux = false;
                Console.WriteLine("La nota " + nota1 + " es " + aux);
            }

            if (nota2 <= 10)
            {
                aux = true;
                Console.WriteLine("La nota " + nota2 + " es " + aux);

            }
            else
            {
                aux = false;
                Console.WriteLine("La nota " + nota2 + " es " + aux);
            }

            if (nota3 <=10)
            {
                aux = true;
                Console.WriteLine("La nota " + nota3 + " es " + aux);

            } else
            {
                aux = false;
                Console.WriteLine("La nota " + nota3 + " es " + aux);
            }

            Console.ReadKey();

        }
    }
}

