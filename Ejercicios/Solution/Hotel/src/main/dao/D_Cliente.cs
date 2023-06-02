using Newtonsoft.Json;

namespace Hotel.main.dao;

public class D_Cliente : D_Factory
{
    public List<Cliente> StringToJsonArray<Cliente>(string json)
    {
        return JsonConvert.DeserializeObject<List<Cliente>>(json);
    }

    public Cliente StringToJsonObject<Cliente>(string json)
    {
        return JsonConvert.DeserializeObject<Cliente>(json);
    }

    public List<Cliente> Load<Cliente>()
    {
        var jsonClient = "....";
        return StringToJsonArray<Cliente>(jsonClient);
    }

    public Cliente Select<Cliente>(int id)
    {
        var jsonClient = "....";
        return StringToJsonObject<Cliente>(jsonClient);
    }

    public void Insert<Cliente>(Cliente data)
    {
        throw new NotImplementedException();
    }

    public void Update<Cliente>(Cliente data)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}