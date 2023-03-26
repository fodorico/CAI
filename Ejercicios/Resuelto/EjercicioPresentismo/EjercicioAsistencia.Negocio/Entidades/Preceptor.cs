using EjercicioAsistencia.Negocio.Entidades.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsistencia.Negocio.Entidades
{
    public class Preceptor : Persona
    {
        protected int _legajo;
        protected bool _activo;

        public Preceptor(int legajo, string nombre, string apellido, bool activo = false)
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
            this._activo = activo;
        }

        internal override string Display()
        {
            return string.Format("{0} - {1}", this._legajo, this._apellido);
        }
    }
}
