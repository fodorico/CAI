using EjercicioTablero.Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 5;
            int numero2 = 6;

            Sumar(numero1, numero2);

            DateTime fechaNacimiento = Convert.ToDateTime("2020-01-01");

            

            Tablero b1 = new Tablero("Tablero 1", "tablero para tareas de prueba, esta instancia dura toda la ejecucion del programa porque esta en el incio del main"); // 0x45AA

            ReferenciaPrueba(b1);

            TareaComun t1 = new TareaComun(1, "Armar repositorio", "Iniciado", 5); // 0xFFA (heap)

            TareaComun t1prima = new TareaComun(1, "Armar repositorio", "Iniciado", 5);

            if (t1.Equals(t1prima))
                Console.WriteLine("son iguales");
            else
                Console.WriteLine("son distintas");

            TareaComun t2 = new TareaComun(2, "Pedir informes", "Pendiente", 6);

            TareaEspecial t3 = new TareaEspecial(3, "Diseñar clases", "Pendiente", 0, 5, 5);
            TareaEspecial t4 = new TareaEspecial(3, "Diseñar base de datos", "Pendiente", 0, 10, 2);

            Tarea t5 = new TareaComun(2, "Analizar estado de tareas", "Pendiente", 6);
            Tarea t6 = new TareaEspecial(3, "Empezar a codificar", "Pendiente", 0, 10, 2);



            MetodoPrueba(t5);
            MetodoPrueba(t6);

            b1.AgregarTarea(t1);
            b1.AgregarTarea(t2);
            
            Tarea objPrueba = t1; // 0xFFA (heap)
            

            objPrueba.Estado = "En Proceso";

            Console.WriteLine(t1);
            Console.WriteLine(t4);

            Console.WriteLine(t1.Estado);

            TareaEspecial te = new TareaEspecialMultiple(1, "", "", 1, 1, 1);
            bool r = te.IsFinalizada();

            bool finalizada1 = t1.IsFinalizada();
            bool finalizada2 = t4.IsFinalizada();

        }

        public static void MetodoPrueba(Tarea t)
        {
            Console.WriteLine("Tarea que hace lo siguiente: " + t.Descripcion);
            Tablero b1 = new Tablero("Tablero 2", "este tablero SOLO se crea cuando se llama este metodo de prueba, cuando finaliza el metodo, la instancia se destruye.");
            if (t is TareaComun)
            {

                Console.WriteLine("Es una tarea común. Con realización " + ((TareaComun)t).FechaRealizacion.ToString() );
            }
            else
            {
                Console.WriteLine("Es una tarea Especial. Con dificultad " + ((TareaEspecial)t).Dificultad);
            }
        }

        public static void Sumar(int a, int b) 
        {
            Console.WriteLine("la suma es " + (a + b).ToString());
            a = 15;
            b = 20;
        }
        public static void ReferenciaPrueba(Tablero t) // 0x45AA
        {
            t.Titulo = "Cambio titulo";

        }
    }
}

