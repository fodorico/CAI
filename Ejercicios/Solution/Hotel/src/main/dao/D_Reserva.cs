using Newtonsoft.Json;

namespace Hotel.main.dao;

public class D_Reserva : D_Factory
{
    public List<Reserva> StringToJson<Reserva>(string json)
    {
        return JsonConvert.DeserializeObject<List<Reserva>>(json);
    }

    public List<Reserva> Load<Reserva>()
    {
        var jsonClient = "....";
        return StringToJson<Reserva>(jsonClient);
    }

    public Reserva Select<Reserva>(int id)
    {
        var jsonClient = "....";
        return StringToJson<Reserva>(jsonClient)[0];
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