using EjercicioAsistencia.Negocio.Entidades.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAsistencia.Negocio.Entidades
{
    public class AlumnoRegular : Alumno
    {
        private string _email;
        public AlumnoRegular(int registro, string nombre, string apellido, string email)
        {
            this._registro = registro;
            this._nombre = nombre;
            this._apellido = apellido;
            this._email = email;
        }
    }
}
