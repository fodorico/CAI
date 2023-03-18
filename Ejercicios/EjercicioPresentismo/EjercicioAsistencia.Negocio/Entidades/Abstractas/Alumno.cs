using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsistencia.Negocio.Entidades.Abstractas
{
    public abstract class Alumno : Persona
    {
        protected int _registro;

        internal override string Display()
        {
            return string.Format("{0} ({1})", this._nombre, this._registro);
        }
    }
}
