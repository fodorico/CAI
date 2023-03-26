using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entidades.Exceptions
{
    public class AgendaCompletaException : Exception
    {
        public AgendaCompletaException() : base("La agenda está completa.") { }
    }
 }
