using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public class User
    {
        public User(Role role, string login, string password)
        {
            Role = role;
            _login = login;
            _password = password;
        }

        private string _login;
        private string _password;

        public Role Role { get; }

        public bool TryLogin(string login, string password) => _login == login && _password == password;
    }
}
