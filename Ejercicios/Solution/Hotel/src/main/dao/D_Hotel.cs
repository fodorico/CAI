using Newtonsoft.Json;

namespace Hotel.main.dao;

public class D_Hotel : D_Factory
{
    public List<Hotel> StringToJson<Hotel>(string json)
    {
        return JsonConvert.DeserializeObject<List<Hotel>>(json);
    }

    public List<Hotel> Load<Hotel>()
    {
        var jsonClient = "....";
        return StringToJson<Hotel>(jsonClient);
    }

    public Hotel Select<Hotel>(int id)
    {
        var jsonClient = "....";
        return StringToJson<Hotel>(jsonClient)[0];
    }

    public void Insert<Hotel>(Hotel data)
    {
        throw new NotImplementedException();
    }

    public void Update<Hotel>(Hotel data)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}