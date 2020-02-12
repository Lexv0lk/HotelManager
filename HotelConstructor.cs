using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class HotelConstructor : Form
    {
        public HotelConstructor()
        {
            InitializeComponent();
        }

        public HotelConstructor(Hotel existingHotel) : this()
        {
            _existingHotel = existingHotel;
            _confirmButton.Text = "Изменить";

            _numberInput.Value = existingHotel.Number;
            _floorsInput.Value = existingHotel.FloorsCount;
            _roomsInput.Value = existingHotel.RoomsCount;

            _countryInput.Text = existingHotel.Adress.Country;
            _cityInput.Text = existingHotel.Adress.City;
            _streetInput.Text = existingHotel.Adress.Street;
            _houseInput.Text = existingHotel.Adress.House;
        }

        private Hotel _existingHotel;

        public Action<Hotel> HotelCreated;

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int number = (int)_numberInput.Value;
            int floors = (int)_floorsInput.Value;
            int rooms = (int)_roomsInput.Value;

            string country = _countryInput.Text;
            string city = _cityInput.Text;
            string street = _streetInput.Text;
            string house = _houseInput.Text;

            if (country == "" || city == "" || street == "" || house == "")
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_existingHotel == null)
            {
                Hotel newHotel = new Hotel(number, floors, rooms, country, city, street, house);
                HotelCreated?.Invoke(newHotel);
            }
            else
            {
                _existingHotel.Number = number;
                _existingHotel.FloorsCount = floors;
                _existingHotel.RoomsCount = rooms;
                _existingHotel.Adress.Country = country;
                _existingHotel.Adress.City = city;
                _existingHotel.Adress.Street = street;
                _existingHotel.Adress.House = house;
            }

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
