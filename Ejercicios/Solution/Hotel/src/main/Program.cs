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
    }
}