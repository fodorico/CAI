using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Negocio.Entidades
{
    public class TareaComun : Tarea
    {
        private DateTime _fechaRealizacion;
        private int _orden;

        public DateTime FechaRealizacion { get => _fechaRealizacion; set => _fechaRealizacion = value; }
        public int Orden { get => _orden; set => _orden = value; }

        public TareaComun(int codigo, string descripcion, string estado, int orden) : base(codigo, descripcion, estado)
        {
            Orden = orden;
        }

        public override bool Validar()
        {
            return _fechaRealizacion.Year > 2022;
        }
    }
}
