using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Negocio.Entidades
{
    public abstract class Tarea : Object
    {
        protected int _codigo;
        protected string _descripcion;
        protected string _estado;
        protected DateTime _fechaAlta;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        protected Tarea(int codigo, string descripcion, string estado)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Estado = estado;
            FechaAlta = DateTime.Now;
        }

        public  bool IsFinalizada()
        {
            if (!Validar())
                _estado = "Error en validación";
         //       throw new Exception("ya sé que no está finaliza.");

            return (Estado == "Finalizada");
        }

        public abstract bool Validar();

        public override string ToString()
        {
            return $"Esta tarea #{this.Codigo.ToString()} es {this._descripcion} con estado {this._estado} ";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Tarea))
                return false;

            Tarea tObj = (Tarea)obj;

            if (tObj.Codigo != this._codigo)
                return false;


            return true;
        }
    }
}
