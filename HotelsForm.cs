using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class HotelsForm : Form
    {
        public HotelsForm()
        {
            InitializeComponent();
            _filteredHotels = _hotels.ToList();

            _countryTextBox.TextChanged += OnTextChanged;
            _cityTextBox.TextChanged += OnTextChanged;
            _streetTextBox.TextChanged += OnTextChanged;
            _houseTextBox.TextChanged += OnTextChanged;
        }

        private List<Hotel> _hotels = new List<Hotel>();
        private List<Hotel> _filteredHotels;

        private void OnTextChanged(object sender, EventArgs e)
        {
            _filteredHotels = GetFilteredHotels();
        }

        private List<Hotel> GetFilteredHotels()
        {
            return _hotels.Where(x => x.Adress.Country.ToLower().Contains(_countryTextBox.Text.ToLower()))
                          .Where(x => x.Adress.City.ToLower().Contains(_cityTextBox.Text.ToLower()))
                          .Where(x => x.Adress.Street.ToLower().Contains(_streetTextBox.Text.ToLower()))
                          .Where(x => x.Adress.House.ToLower().Contains(_houseTextBox.Text.ToLower()))
                          .ToList();
        }
    }
}
