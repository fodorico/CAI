using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int posiciones = 802;
            int[] numeros = new int[posiciones];
            int i = 0;
            string lista = "";
            do
            {
                numeros[i] = i + 1;
                if ((numeros[i] % 3 == 0) && (numeros[i] % 5 == 0))
                {
                    lista = numeros[i] + " - FooBar";
                }else if (numeros[i] % 3 == 0)
                {
                    lista = numeros[i] + " - Foo";
                }else if (numeros[i] % 5 == 0)
                {
                    lista = numeros[i] + " - Bar";
                }
                else
                {
                    lista = numeros[i].ToString();
                }
                Console.WriteLine(lista);
                i++;
            } while (i < posiciones);
            Console.ReadKey();
        }
    }
}
