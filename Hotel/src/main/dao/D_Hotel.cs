using Newtonsoft.Json;

namespace Hotel.main.dao;

public class D_Hotel : D_Factory
{
    public List<Hotel> StringToJsonArray<Hotel>(string json)
    {
        return JsonConvert.DeserializeObject<List<Hotel>>(json);
    }

    public Hotel StringToJsonObject<Hotel>(string json)
    {
        return JsonConvert.DeserializeObject<Hotel>(json);
    }

    public List<Hotel> Load<Hotel>()
    {
        var jsonClient = "....";
        return StringToJsonArray<Hotel>(jsonClient);
    }
    
    public List<Hotel> Load<Hotel>(int id)
    {
        var jsonClient = "....";
        return StringToJsonArray<Hotel>(jsonClient);
    }

    public Hotel Select<Hotel>(int id)
    {
        var jsonClient = "....";
        return StringToJsonObject<Hotel>(jsonClient);
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