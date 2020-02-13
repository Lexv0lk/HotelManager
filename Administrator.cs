namespace HotelManager
{
    public class Administrator : IIdentifiable
    {
        public static Administrator Authorized;

        public Administrator(int id, string login, string password, string name, string surname,
            string middleName, string phone, Hotel hotel)
        {
            Id = id;
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            Phone = phone;
            Hotel = hotel;
        }

        public string Login;
        public string Password;

        public string Name;
        public string Surname;
        public string MiddleName;
        public string Phone;
        public Hotel Hotel;

        public int Id { get; }

        public bool TryLogin(string login, string password) => Login == login && Password == password;
    }
}
