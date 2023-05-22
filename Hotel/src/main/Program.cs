namespace Hotel.main;

public class Program
{
    private const string OpcionElegida = "Por favor seleccione la opción deseada: ";

    public static void Main()
    {
        MenuInicial();
    }

    private static void MenuInicial()
    {
        Console.WriteLine($"Bienvenido!! {OpcionElegida}");
        Console.WriteLine("1) Cliente registrado \n2) Registrarme ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("\npor favor ingrese su DNI");
                string DNI = Console.ReadLine();

                Console.WriteLine(
                    "\nBienvenido *muestra nombre*, por favor ingrese una opcion\n1)Consultar datos \n2) Consultar reserva \n3) Crear Reserva  ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "3":
                        Console.WriteLine("\npor favor seleccione un hotel \n1)Hotel grande \n2)Hotel Rojo");
                        string hotel = Console.ReadLine();
                        Console.WriteLine("\npor favor ingrese una fecha con el formato DDMMAAAA");
                        Console.ReadLine();
                        Console.WriteLine("\npor favor ingrese cantidad de huespedes");
                        Console.ReadLine();
                        Console.WriteLine(
                            "\nPor favor seleccione una de las habitaciones disponibles \n1)habitacion 1: 2 camas simples ($100 por noche) \n2)suite: Cama matrimonial con toro mecanico ($10.000 por noche");
                        Console.ReadLine();
                        Console.WriteLine(
                            "\nDatos de su reserva \nHotel Rojo \nfechas de tal a tal \nHabitacion: Suite con toro mecanico \nPrecio total $50.000 \n\nDesea confirmar la reserva? \n1)Si \n2)No");
                        Console.ReadLine();
                        // "crear id reserva"
                        //hotel
                        //fecha
                        //habitacion

                        Console.WriteLine(
                            "\nGracias Usuario, tu reserva se realizo con exito maestro: \nUsuario: jorge messi \nHotel: Hotel Rojo \nHabiutacion: Suite \nHuespedes: 2 \nPrecio total $10 \n\nMuchas gracias");
                        Console.ReadLine();
                        break;
                }

                break;
        }
    }
}