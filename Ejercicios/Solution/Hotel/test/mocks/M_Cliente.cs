using Hotel.main.entity;
using Hotel.main.@enum;

namespace Hotel.test.mocks;

public class M_Cliente
{
    public Cliente C0 = new Cliente(001, E_TipoDocumento.DNI, 010, "Pepe", "Falso", 012345678);
}