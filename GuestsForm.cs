using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class GuestsForm : ListForm<Guest>
    {
        public GuestsForm()
        {
            InitializeComponent();
        }

        protected override ListView ListView => _guestListView;
        protected override List<Guest> ItemList => Database.Guests;
        protected override ContextMenuStrip MenuStrip => _contextMenuStrip;
        protected override ToolStripMenuItem DeleteStripMenuItem => _deleteStripMenuItem;
        protected override string KeyStart => "Guest";

        protected override ListViewItem GetListViewItem(Guest guest)
        {
            ListViewItem guestItem = new ListViewItem($"{guest.Name} {guest.Surname} {guest.MiddleName}");
            guestItem.Tag = guest.Id;
            return guestItem;
        }

        protected override Constructor<Guest> GetCreatingConstructor() => new GuestConstructor(GetNewId());

        protected override Constructor<Guest> GetEditingConstructor(Guest guest) => new GuestConstructor(guest);

        protected override bool IsSuitable(Guest item) => true;
    }
}
