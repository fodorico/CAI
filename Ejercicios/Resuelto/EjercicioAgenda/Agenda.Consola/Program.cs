using Agenda.Entidades.Entidades;
using Agenda.Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agenda.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaContactos agenda = new AgendaContactos("Diario", "Electrónica", 5);

            ContactoFisico contacto1 = new ContactoFisico(1,"Cecilia", "Lopez", "1234", "moldes 123", DateTime.Now.AddYears(-35));

            ContactoBase contacto2 = new ContactoJuridico(2,"Carlos", "Landa", "789456", "11 de septiembre","Pyme SRL" , DateTime.Now.AddYears(-2));

            ContactoEspecial ce1 = new ContactoEspecial(3,"Maria","Lopez");

            ContactoBase ce2 = new ContactoEspecial(4,"Juan", "Perez");


            ContactoBase crandomg = GetContactoRandom();
            
            if (crandomg is ContactoFisico)
            {
                ContactoFisico castToContacto = (ContactoFisico)crandomg;
                Console.WriteLine("soy un contacto fisico");
                Console.WriteLine(castToContacto.FechaNacimiento);

            }
            else if(crandomg is ContactoEspecial)
            {
                ContactoEspecial castToContactoEspecial = (ContactoEspecial)crandomg;
                Console.WriteLine(castToContactoEspecial.Antiguedad);
            }


            agenda.AgregarContacto(contacto1);

            agenda.AgregarContacto(contacto2);

            agenda.AgregarContacto(ce1);
            agenda.AgregarContacto(ce2);



        }

        public static ContactoBase GetContactoRandom()
        {
            if(DateTime.Now.Minute > 30)
            {
                return new ContactoFisico(2, "Carlos", "Landa", "789456", "11 de septiembre", DateTime.Now.AddYears(-21));
            }
            else
            {
                return new ContactoEspecial(4, "Juan", "Perez");
            }
        }

        //static void Main(string[] args)
        //{
        //    AgendaContactos agenda = new AgendaContactos("Diario", "Electrónica", 5);
            
        //    Contacto contacto1 = new Contacto("Cecilia", "Lopez", "1234", "moldes 123", DateTime.Now.AddYears(-35),1);

        //    Contacto contacto2 = new Contacto("Carlos", "Landa", "789456", "11 de septiembre", DateTime.Now.AddYears(-21),2);

        //    try
        //    {
        //        // si no puede agregar el contacto solo muestra msg
        //        agenda.AgregarContacto(contacto1);

        //        // sin no puede llamar, debe borrar el contacto y mostrar mensaje
        //        contacto1.LLamar();
        //    }
        //    catch (AgendaCompletaException agendaCompletaEx)
        //    {
        //        Console.WriteLine(agendaCompletaEx.Message);
        //    }
        //    catch (ContactoNoAtiendeException contactoNoAtiendeEx)
        //    {
        //        agenda.EliminarContacto(contactoNoAtiendeEx.Codigo);

        //        Console.WriteLine(contactoNoAtiendeEx.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error desconocido. Detalle: " + ex.Message);
        //    }


        //}
    }
}
