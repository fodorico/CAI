using Hotel.main.@enum;

namespace Hotel.main.entity;

public class Cliente : A_Person
{
    private int _legajo; // field
    
    public int Legajo // property
    {
        get { return _legajo; } // get method
        set { _legajo = value; } // set method
    }

    public Cliente(int legajo, E_TipoDocumento eTipoDocumento, int documento, string nombre, string apellido, int telefono)
    {
        Legajo = legajo;
        ETipoDocumento = eTipoDocumento;
        Documento = documento;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
    }
}