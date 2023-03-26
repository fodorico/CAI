using EjercicioAsistencia.Negocio.Entidades.Abstractas;
using EjercicioAsistencia.Negocio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsistencia.Negocio.Entidades
{
    public class Presentismo
    {
        private List<Alumno> _alumnos;
        private List<Preceptor> _preceptores;
        private List<Asistencia> _asistencias;


        public Presentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();
            //_fechas = new List<string>();

            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));

            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos"));


        }

        private bool AsistenciaRegistrada(string fecha)
        {
            return _asistencias.Any(reg => reg.Fecha == fecha);
        }

        private int GetCantidadAlumnosRegulares()
        {
            int cantidad = 0;
            foreach(Alumno alumno in this._alumnos)
            {
                if(alumno is AlumnoRegular)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Preceptor GetPreceptorActivo()
        {
            return _preceptores.First();
        }

        /// <summary>
        /// Devuelve la lista total de alumnos si y solo si la fecha no está registrada
        /// </summary>
        /// <returns>Listado de Alumnos</returns>
        public List<Alumno> GetListaAlumnos()
        {
            return this._alumnos;
        }


        /// <summary>
        /// Agrega una coleccion de asistencias a la lista de Presentismo.
        /// </summary>
        /// <param name="asistencias">Recibe una collection de el objeto asistencia previamente cargados en la UI</param>
        public void AgregarAsistencia(List<Asistencia> asistencias)
        {

            if (asistencias == null || asistencias.Count == 0)
                throw new Exception("No hay asistencias para agregar");

            if (asistencias.Count != this.GetCantidadAlumnosRegulares())
                throw new AsistenciaInconsistenteException();

            if (AsistenciaRegistrada(asistencias.First().Fecha))
                throw new AsistenciaExistenteEseDiaException();

            this._asistencias.AddRange(asistencias);
        }

        /// <summary>
        /// Devuelve la coleccion de obj Asistencia filtrada por fecha (la de referencia)
        /// </summary>
        /// <param name="fecha">Fecha de referencia en formato yyyy-mm-dd</param>
        /// <returns>lista de asistencias</returns>
        public List<Asistencia> GetAsistenciasPorFecha(string fecha)
        {
          
            List<Asistencia> resultado = new List<Asistencia>();

            foreach(Asistencia asist in this._asistencias)
            {
                if(asist.Fecha == fecha)
                {
                    resultado.Add(asist);
                }
            }


            return resultado;
        }




    }
}
