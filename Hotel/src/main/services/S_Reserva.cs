using System.Collections.Specialized;
using Hotel.main.dao;
using Hotel.main.entity;
using Utils;

namespace Hotel.main.services;

public class S_Reserva
{
    public List<Reserva> GetReservasData(string id)
    {
        return new D_Reserva().Load(id);
    }

    public void ReservaMenu(Reserva r)
    {
        var opt = true;
        while (opt)
        {
            Console.Clear();
            ShowData(r);
            // opt = SwitchMenuReserva(ShowMenuReserva(), r);
        }
    }

    private void ShowData(Reserva r)
    {
        Console.WriteLine("|-----------------------------------|");
        Console.WriteLine("Nombre: " + h.nombre);
        Console.WriteLine("Estrellas: " + h.estrellas);
        Console.WriteLine("Direccion: " + h.direccion);
        Console.WriteLine("Amenities: " + h.amenities);
        
        Console.WriteLine("|-----------------------------------|\n\n");
    }

    private int ShowMenuReserva()
    {
        Console.WriteLine("¿Qué datos le gustaría modificar?");
        Console.WriteLine("1) Nombre");
        Console.WriteLine("2) Estrellas");
        Console.WriteLine("3) Dirección");
        Console.WriteLine("4) Amenities");
        Console.WriteLine("0) Salir");
        return ValidateInput.ValidateInteger("Ingrese la opción deseada: ", -1, 5, true);
    }

    private bool SwitchMenuReserva(int i, entity.Hotel h)
    {
        switch (i)
        {
            case 1:
                var tempN = ValidateInput.ValidateString("Ingrese el nuevo Nombre: ", "IsLetter");
                h.nombre = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempN : h.nombre;
                break;
            case 2:
                var tempE = ValidateInput.ValidateInteger("Ingrese la nueva cantidad de Estrellas: ", -1, 6, true);
                h.estrellas = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempE : h.estrellas;
                break;
            case 3:
                var tempDi = ValidateInput.ValidateString("Ingrese la nueva Dirección: ");
                h.direccion = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempDi : h.direccion;
                break;
            case 4:
                var tempA = ValidateInput.ValidateBoolean("Ingrese si tiene Comodidades (Si/No): ");
                h.amenities = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempA : h.amenities;
                break;
            default:
                return false;
        }
        
        new D_Hotel().Update(h);
        return true;
    }

    public NameValueCollection ReservaMap(Reserva r)
    {
        var n = new NameValueCollection
        {
            { "id", h.id.ToString() },
            { "Estrellas", h.estrellas.ToString() },
            { "Usuario", h.usuario.ToString() },
            { "Amenities", h.amenities.ToString() },
            { "Direccion", h.direccion },
            { "Nombre", h.nombre }
        };
        return n;
    }
}