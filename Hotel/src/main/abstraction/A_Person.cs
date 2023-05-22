using Hotel.main.@enum;

public abstract class A_Person
{
    private E_TipoDocumento _eTipoDocumento; // field
    private int _documento; // field
    private string _nombre; // field
    private string _apellido; // field
    private int _telefono; // field

    public E_TipoDocumento ETipoDocumento // property
    {
        get { return _eTipoDocumento; } // get method
        set { _eTipoDocumento = value; } // set method
    }

    public int Documento // property
    {
        get { return _documento; } // get method
        set { _documento = value; } // set method
    }

    public string Nombre // property
    {
        get { return _nombre; } // get method
        set { _nombre = value; } // set method
    }

    public string Apellido // property
    {
        get { return _apellido; } // get method
        set { _apellido = value; } // set method
    }

    public int Telefono // property
    {
        get { return _telefono; } // get method
        set { _telefono = value; } // set method
    }
}