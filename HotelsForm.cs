using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class HotelsForm : ListForm<Hotel>
    {
        public HotelsForm()
        {
            InitializeComponent();
            _filteredHotels = Database.Hotels.ToList();

            _countryTextBox.TextChanged += OnTextChanged;
            _cityTextBox.TextChanged += OnTextChanged;
            _streetTextBox.TextChanged += OnTextChanged;
            _houseTextBox.TextChanged += OnTextChanged;
        }

        private List<Hotel> _filteredHotels;

        protected override ListView ListView => _hotelsListView;
        protected override List<Hotel> ItemList => Database.Hotels;
        protected override ContextMenuStrip MenuStrip => _contextMenuStrip;
        protected override ToolStripMenuItem DeleteStripMenuItem => _deleteStripMenuItem;
        protected override string KeyStart => "Hotel";

        private void OnTextChanged(object sender, EventArgs e)
        {
            _filteredHotels = GetFilteredHotels();
            ListView.Items.Clear();
            for (int i = 0; i < _filteredHotels.Count; i++)
                ListView.Items.Add(GetListViewItem(_filteredHotels[i]));
        }

        private List<Hotel> GetFilteredHotels()
        {
            return Database.Hotels.Where(x => x.Adress.Country.ToLower().Contains(_countryTextBox.Text.ToLower()))
                                  .Where(x => x.Adress.City.ToLower().Contains(_cityTextBox.Text.ToLower()))
                                  .Where(x => x.Adress.Street.ToLower().Contains(_streetTextBox.Text.ToLower()))
                                  .Where(x => x.Adress.House.ToLower().Contains(_houseTextBox.Text.ToLower()))
                                  .ToList();
        }

        protected override ListViewItem GetListViewItem(Hotel hotel)
        {
            ListViewItem newItem = new ListViewItem($"Гостиница {hotel.Number}");
            newItem.Tag = hotel.Id;
            return newItem;
        }

        protected override Constructor<Hotel> GetCreatingConstructor() => new HotelConstructor(GetNewId());

        protected override Constructor<Hotel> GetEditingConstructor(Hotel hotel) => new HotelConstructor(hotel);

        protected override bool IsSuitable(Hotel item) => true;
    }
}
