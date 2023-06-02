using Hotel.main.dao;

namespace Hotel.main.services;

public class S_Hotel
{
    public List<entity.Hotel> GetHotelData(string clientId)
    {
        return new D_Hotel().Load<entity.Hotel>(int.Parse(clientId));
    }
}