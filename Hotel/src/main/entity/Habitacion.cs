using Hotel.main.@enum;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel.main.entity;

public class Habitacion
{
    //Atributos
    private int _codigo_habitacion;
    private string _tipo;
    private string _estado;
    private double _precio;
    private bool _habilitada;

    //Popiedades

    public int Codigo_habitacion { get => _codigo_habitacion; set => _codigo_habitacion = value; }
    public string Tipo { get => _tipo; set => _tipo = value; }
    public string Estado { get => _estado; set => _estado = value; }
    public double Precio { get => _precio; set => _precio = value; }
    public bool Habilitada { get => _habilitada; set => _habilitada = value; }

    //Constructor
    public Habitacion (int codigo_habitacion, string tipo, string estado, double precio, bool habilitada)
    {
        Codigo_habitacion = codigo_habitacion;
        Tipo = tipo;
        Estado = estado;
        Precio = precio;
        Habilitada = habilitada;

    }




}