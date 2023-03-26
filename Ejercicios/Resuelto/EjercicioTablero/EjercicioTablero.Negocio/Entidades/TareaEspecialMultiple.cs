using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Negocio.Entidades
{
    public class TareaEspecialMultiple : TareaEspecial
    {
        public TareaEspecialMultiple(int codigo, string descripcion, string estado, double porcentajeFinalizacion, int dificultad, int prioridad) : base(codigo, descripcion, estado, porcentajeFinalizacion, dificultad, prioridad)
        {
        }

        //public override bool IsFinalizada()
        //{
        //    if (base.IsFinalizada())
        //        return false;
        //    else
        //        return true;

        //    //return !base.IsFinalizada();
        //}

        public override bool Validar()
        {
            return base.Validar();
        }
    }
}
