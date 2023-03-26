using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTablero.Negocio.Entidades
{
    public class Tablero
    {
        private string _titulo;
        private string _descripcion;
        private List<Tarea> _tareas;
        private DateTime _fechaInicioProyecto;

        public Tablero(string titulo, string descripcion)
        {
            _titulo = titulo;
            _descripcion = descripcion;
            _tareas = new List<Tarea>();
            _fechaInicioProyecto = DateTime.Now;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; }
        public IEnumerable<Tarea> Tareas { get => _tareas;  }
        public DateTime FechaInicioProyecto { get => _fechaInicioProyecto; }

        public void AgregarTarea(TareaComun t1)
        {
            
        }
    }
}
