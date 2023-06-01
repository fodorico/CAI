namespace Hotel.main.dao;

public interface D_Factory
{
    List<T> StringToJson<T>(string json);
    List<T> Load<T>();
    T Select<T>(int id);
    void Delete(int id);
    void Insert<T>(T data);
    void Update<T>(T data);
}