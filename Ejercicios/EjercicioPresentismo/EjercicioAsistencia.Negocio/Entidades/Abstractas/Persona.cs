using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsistencia.Negocio.Entidades.Abstractas
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;

        internal abstract string Display();

        public override string ToString()
        {
            return this.Display();
        }
    }
}
