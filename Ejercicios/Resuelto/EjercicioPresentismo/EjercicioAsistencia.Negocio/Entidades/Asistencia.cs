using EjercicioAsistencia.Negocio.Entidades.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsistencia.Negocio.Entidades
{
    public class Asistencia
    {
        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Alumno _alumno;
        private Preceptor _preceptor;
        private bool _estaPresente;

        public string Fecha { get { return _fechaReferencia; } }

        public Asistencia(Alumno a, Preceptor p, string fecha,  bool presente)
        {
            this._fechaReferencia = fecha;
            this._fechaHoraReal = DateTime.Now;
            this._preceptor = p;
            this._alumno = a;
            this._estaPresente = presente;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} está presente {4} por {2} tomado {3}",
                this._fechaReferencia, this._alumno, this._preceptor, this._fechaHoraReal.ToString(), this._estaPresente ? "SI" : "NO");
        }
    }
}
