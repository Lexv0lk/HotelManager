using System;
using System.Linq;

namespace HotelManager
{
    public partial class AdministratorConstructor : Constructor<Administrator>
    {
        public AdministratorConstructor()
        {
            InitializeComponent();

            if (Database.Hotels.Count > 0)
                foreach (var hotel in Database.Hotels)
                    _hotelUpDown.Items.Add($"Гостиница {hotel.Number}");
        }

        public AdministratorConstructor(int newId) : this()
        {
            _newId = newId;
        }

        public AdministratorConstructor(Administrator existingAdministrator) : this()
        {
            _existingAdministrator = existingAdministrator;

            _loginInput.Text = _existingAdministrator.Login;
            _passwordInput.Text = _existingAdministrator.Password;
            _nameInput.Text = _existingAdministrator.Name;
            _surnameInput.Text = _existingAdministrator.Surname;
            _middleNameInput.Text = _existingAdministrator.MiddleName;
            _phoneInput.Text = _existingAdministrator.Phone;
            _hotelUpDown.SelectedIndex = _hotelUpDown.Items.IndexOf($"Гостиница {_existingAdministrator.Hotel.Number}");

            _confirmButton.Text = "Изменить";
        }

        private int _newId;
        private Administrator _existingAdministrator;

        public override event Action<Administrator> ItemCreated;

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string login = _loginInput.Text;
            string password = _passwordInput.Text;
            string name = _nameInput.Text;
            string surname = _surnameInput.Text;
            string middleName = _middleNameInput.Text;
            string phone = _phoneInput.Text;

            int selectedIndex = _hotelUpDown.SelectedIndex;

            if (login == "" || password == "" || name == "" || surname == "" || middleName == "" || phone == "" || selectedIndex == -1)
            {
                DisplayError("Не все поля заполнены!");
                return;
            }

            Hotel newHotel = Database.Hotels.First(x => x.Number == int.Parse(_hotelUpDown.Items[_hotelUpDown.SelectedIndex].ToString().Split(' ')[1]));

            if (_existingAdministrator == null)
            {
                Administrator newAdministrator = new Administrator(_newId, login, password, name, surname, middleName, phone, newHotel);
                ItemCreated?.Invoke(newAdministrator);
            }
            else
            {
                _existingAdministrator.Login = login;
                _existingAdministrator.Password = password;
                _existingAdministrator.Name = name;
                _existingAdministrator.Surname = surname;
                _existingAdministrator.MiddleName = middleName;
                _existingAdministrator.Phone = phone;
                _existingAdministrator.Hotel = newHotel;
            }

            Close();
        }
    }
}
