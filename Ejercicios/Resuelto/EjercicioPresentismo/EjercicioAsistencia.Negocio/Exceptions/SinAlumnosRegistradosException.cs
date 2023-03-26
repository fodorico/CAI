using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsistencia.Negocio.Exceptions
{
    public class SinAlumnosRegistradosException : Exception
    {
        public SinAlumnosRegistradosException() : base("No hay alumnos registrados.") { }
    }
}
