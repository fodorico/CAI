using Newtonsoft.Json;

namespace Hotel.main.dao;

public class D_Reserva : D_Factory
{
    public List<Reserva> StringToJsonArray<Reserva>(string json)
    {
        return JsonConvert.DeserializeObject<List<Reserva>>(json);
    }

    public Reserva StringToJsonObject<Reserva>(string json)
    {
        return JsonConvert.DeserializeObject<Reserva>(json);
    }

    public List<Reserva> Load<Reserva>()
    {
        var jsonClient = "....";
        return StringToJsonArray<Reserva>(jsonClient);
    }

    public Reserva Select<Reserva>(int id)
    {
        var jsonClient = "....";
        return StringToJsonObject<Reserva>(jsonClient);
    }

    public void Insert<Reserva>(Reserva data)
    {
        throw new NotImplementedException();
    }

    public void Update<Reserva>(Reserva data)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}