using Newtonsoft.Json;

namespace Hotel.main.dao;

public class D_Habitacion : D_Factory
{
    public List<Habitacion> StringToJson<Habitacion>(string json)
    {
        return JsonConvert.DeserializeObject<List<Habitacion>>(json);
    }

    public List<Habitacion> Load<Habitacion>()
    {
        var jsonClient = "....";
        return StringToJson<Habitacion>(jsonClient);
    }

    public Habitacion Select<Habitacion>(int id)
    {
        var jsonClient = "....";
        return StringToJson<Habitacion>(jsonClient)[0];
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