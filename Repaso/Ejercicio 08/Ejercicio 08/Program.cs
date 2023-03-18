using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 0;
            int mes = 0;
            int año = 0;
            DateTime fechaActual = DateTime.Today;
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año:");
            año = int.Parse(Console.ReadLine());
            DateTime fechaUsuario = new DateTime(año, mes, dia);
            TimeSpan diferencia = fechaUsuario - fechaActual;
            int resultadoDias = diferencia.Days;
            Console.WriteLine("La diferencia de fechas es de " + resultadoDias + " días.");
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadLine();
            
        }
    }
}
