using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string evaluador = "";
            Console.WriteLine("Ingrese la palabra a evaluar:");
            string palabra = Console.ReadLine().ToUpper();
            int i = palabra.Length;
            int pos = i - 1;
            do
            {
                evaluador = evaluador + palabra[pos];
                pos--;
            } while (pos >= 0);
            if (evaluador == palabra)
            {
                Console.WriteLine("Es palíndromo");
            }
            else
            {
                Console.WriteLine("No es palíndromo");
            }
            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
