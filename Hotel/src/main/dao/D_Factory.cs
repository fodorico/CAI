using Hotel.main.entity;

namespace Hotel.main.dao;

public interface D_Factory<T>
{
    List<T> Load();
    T Select(string id);
    ResultadoTransaccion Insert(T data);
    ResultadoTransaccion Update(T data);
    ResultadoTransaccion Delete(T data);
}