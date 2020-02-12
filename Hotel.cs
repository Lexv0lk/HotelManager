namespace HotelManager
{
    public class Hotel : IIdentifiable
    {
        public Hotel(int id, int number, int floorsCount, int roomsCount, string country, 
            string city, string street, string house)
        {
            Id = id;
            Number = number;
            FloorsCount = floorsCount;
            RoomsCount = roomsCount;

            Adress = new Adress(country, city, street, house);
        }

        public int Number;
        public int FloorsCount;
        public int RoomsCount;

        public int Id { get; }
        public Adress Adress { get; }
    }
}
