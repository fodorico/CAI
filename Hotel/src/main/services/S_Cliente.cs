using Hotel.main.dao;
using Hotel.main.entity;
using Utils;

namespace Hotel.main.services;

public class S_Cliente
{
    public Cliente GetClientData(int id)
    {
        return new D_Cliente().Select<Cliente>(id);
    }

    public void ClienteMenu(Cliente c)
    {
        var opt = true;
        while (opt)
        {
            Console.Clear();
            ShowData(c);
            opt = SwitchMenuCliente(ShowMenuCliente(), c);
        }
    }

    private void ShowData(Cliente c)
    {
        // Mostrar en pantalla los datos del Cliente
        Console.WriteLine("|-----------------------------------|");
        Console.WriteLine("DNI: " + c.dni);
        Console.WriteLine("Nombre Completo: " + c.nombre + " " + c.apellido);
        Console.WriteLine("Direccion: " + c.direccion);
        Console.WriteLine("Email: " + c.email);
        Console.WriteLine("Telefono: " + c.telefono);
        Console.WriteLine("Legajo: " + c.usuario);
        Console.WriteLine("Fecha de Nacimiento: " + c.fechaNacimiento);
        Console.WriteLine("|-----------------------------------|\n\n");
    }

    private int ShowMenuCliente()
    {
        Console.WriteLine("¿Qué datos le gustaría modificar?");
        Console.WriteLine("1) DNI");
        Console.WriteLine("2) Nombre");
        Console.WriteLine("3) Apellido");
        Console.WriteLine("4) Dirección");
        Console.WriteLine("5) Email");
        Console.WriteLine("6) Telefono");
        Console.WriteLine("7) Legajo");
        Console.WriteLine("8) Fecha de Nacimiento");
        Console.WriteLine("0) Salir");
        return ValidateInput.ValidateInteger("Ingrese la opción deseada: ", -1, 9, true);
    }

    private bool SwitchMenuCliente(int i, Cliente c)
    {
        // Permitir Modificar los datos
        // Guardar los datos en las variables tambien
        switch (i)
        {
            case 1:
                var tempDn = ValidateInput.ValidateInteger("Ingrese el nuevo DNI: ", -1, 99999999, true);
                c.dni = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempDn : c.dni;
                break;
            case 2:
                var tempN = ValidateInput.ValidateString("Ingrese el nuevo Nombre: ", "IsLetter");
                c.nombre = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempN : c.nombre;
                break;
            case 3:
                var tempA = ValidateInput.ValidateString("Ingrese el nuevo Apellido: ", "IsLetter");
                c.apellido = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempA : c.apellido;
                break;
            case 4:
                var tempDi = ValidateInput.ValidateString("Ingrese la nueva Dirección: ");
                c.direccion = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempDi : c.direccion;
                break;
            case 5:
                var tempE = ValidateInput.ValidateString("Ingrese el nuevo Email: ");
                c.email = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempE : c.email;
                break;
            case 6:
                var tempT =
                    ValidateInput.ValidateString("Ingrese el nuevo Telefono (Sin espcios/guiones): ", "IsDigit");
                c.telefono = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempT : c.telefono;
                break;
            case 7:
                var tempL = ValidateInput.ValidateString("Ingrese el nuevo Legajo: ", "IsDigit");
                c.usuario = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI" ? tempL : c.usuario;
                break;
            case 8:
                var tempFn = ValidateInput.ValidateDateTime("Ingrese la nueva Fecha de Nacimiento (DD-MM-YYYY): ");
                c.fechaNacimiento = ValidateInput.Confirm(ValidateInput.ConfirmMessage) == "SI"
                    ? tempFn
                    : c.fechaNacimiento;
                break;
            default:
                return false;
        }
        return true;
    }
}