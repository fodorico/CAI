using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsistencia.Negocio.Exceptions
{
    public class AsistenciaInconsistenteException : Exception
    {
        public AsistenciaInconsistenteException() : base("La cantidad de alumnos regulares no coincide con la asistencia.") { }

    }
}
