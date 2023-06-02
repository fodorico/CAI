using Newtonsoft.Json;

namespace Hotel.main.dao;

public class D_Habitacion : D_Factory
{
    public List<Habitacion> StringToJsonArray<Habitacion>(string json)
    {
        return JsonConvert.DeserializeObject<List<Habitacion>>(json);
    }

    public Habitacion StringToJsonObject<Habitacion>(string json)
    {
        return JsonConvert.DeserializeObject<Habitacion>(json);
    }

    public List<Habitacion> Load<Habitacion>()
    {
        var jsonClient = "....";
        return StringToJsonArray<Habitacion>(jsonClient);
    }

    public Habitacion Select<Habitacion>(int id)
    {
        var jsonClient = "....";
        return StringToJsonObject<Habitacion>(jsonClient);
    }

    public void Insert<Habitacion>(Habitacion data)
    {
        throw new NotImplementedException();
    }

    public void Update<Habitacion>(Habitacion data)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}