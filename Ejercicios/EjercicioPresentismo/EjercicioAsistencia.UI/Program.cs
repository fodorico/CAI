using EjercicioAsistencia.Negocio.Entidades;
using EjercicioAsistencia.Negocio.Entidades.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsistencia.UI
{
    public class Program
    {
        private static Presentismo _presentismo;

        static Program()
        {
            _presentismo = new Presentismo();
        }
        static void Main(string[] args)
        {
            try
            {

            
                Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();

                bool consolaActiva = true;

                while (consolaActiva)
                {
                    DesplegarOpcionesMenu();
                    string opcionMenu = Console.ReadLine();
                    switch (opcionMenu)
                    {
                        case "1":
                            TomarAsistencia(preceptorActivo);
                            break;
                        case "2":
                            MostrarAsistencia();
                            break;
                        case "X":
                            consolaActiva = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error general");
            }
        }

        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }
        static void TomarAsistencia(Preceptor p)
        {
            try
            {

            
                // Ingreso fecha
                Console.WriteLine("ingrese fecha: (yyyy-mm-dd)");
                string fecha = Console.ReadLine();
                List<Asistencia> asistencias = new List<Asistencia>();
                List<Alumno> alumnos = _presentismo.GetListaAlumnos();

                ListaAlumnos(alumnos);

                // para cada alumno solo preguntar si está presente
                foreach(Alumno alu in alumnos)
                {
                    if (alu is AlumnoRegular)
                    {
                        Console.WriteLine($"El alumno {alu} se encuentra presente? (S/N)");
                        // validamos que el usuario  solo pueda poner S o N
                        string resp = Console.ReadLine();
                        bool r = false;
                        if (resp == "S")
                            r = true;
                        // agrego la lista de asistencia
                        Asistencia a = new Asistencia(alu, p, fecha, r);
                        asistencias.Add(a);
                    }
                    else
                    {
                        Console.WriteLine($"El alumno {alu} es oyente");
                    }
                }

                _presentismo.AgregarAsistencia(asistencias);
            }
            catch (Exception)
            {

                throw;
            }

            // Error: mostrar el error y que luego muestre el menu nuevamente
        }
        static void MostrarAsistencia()
        {
            try
            {
                Console.WriteLine("ingrese fecha: (yyyy-mm-dd)");
                string fecha = Console.ReadLine();

                List<Asistencia> lista = _presentismo.GetAsistenciasPorFecha(fecha);

                if (lista == null || lista.Count == 0)
                {
                    Console.WriteLine($"No hay registros para la fecha {fecha}");
                    
                }
                else
                {
                    foreach (Asistencia asist in lista)
                    {
                        Console.WriteLine(asist);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        static void ListaAlumnos(List<Alumno> alumnos)
        {
            // Listar los alumnos

            foreach (Alumno alu in alumnos)
            {
                Console.WriteLine(alu);
            }
        }
    }

}
