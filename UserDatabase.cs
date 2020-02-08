using System.Collections.Generic;

namespace HotelManager
{
    static class UserDatabase
    {
        public static IReadOnlyCollection<User> Users => _users.AsReadOnly();

        private static List<User> _users = new List<User> 
        { 
            new User(Role.Manager, "Manager", "Manager"),
            new User(Role.Administrator, "Admin", "Admin") 
        };
    }
}
