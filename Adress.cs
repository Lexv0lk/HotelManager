namespace HotelManager
{
    public class Adress
    {
        public Adress(string country, string city, string street, string house)
        {
            Country = country;
            City = city;
            Street = street;
            House = house;
        }

        public string Country;
        public string City;
        public string Street;
        public string House;
    }
}
