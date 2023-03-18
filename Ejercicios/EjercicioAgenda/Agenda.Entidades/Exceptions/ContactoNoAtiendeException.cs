using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entidades.Exceptions
{
    public class ContactoNoAtiendeException : Exception
    {
        private int _codigo;
        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }
        public ContactoNoAtiendeException(int codigo) : base("El contacto no atiende el llamado.") {
            _codigo = codigo;
        }

        //public ContactoNoAtiendeException(string msg) : base(msg) { 
        //}
    }
}
