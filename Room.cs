namespace HotelManager
{
    public class Room : IIdentifiable
    {
        public Room(int number, int innerRoomsCount, float area, int id, Hotel hotel)
        {
            Number = number;
            InnerRoomsCount = innerRoomsCount;
            Area = area;
            Id = id;
            Hotel = hotel;
        }

        public int Number;
        public int InnerRoomsCount;
        public float Area;
        public Hotel Hotel;

        public int Id { get; }
    }
}
