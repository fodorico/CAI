using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsistencia.Negocio.Exceptions
{
    public class AsistenciaExistenteEseDiaException : Exception
    {
        public AsistenciaExistenteEseDiaException() : base("La asistencia de ese día ya está confirmada.") { }
    }
}
