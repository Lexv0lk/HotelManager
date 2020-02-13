using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class RoomsForm : ListForm<Room>
    {
        public RoomsForm()
        {
            InitializeComponent();
        }

        protected override ListView ListView => _roomListView;
        protected override List<Room> ItemList => Database.Rooms;
        protected override ContextMenuStrip MenuStrip => _contextMenuStrip;
        protected override ToolStripMenuItem DeleteStripMenuItem => _deleteStripMenuItem;
        protected override string KeyStart => "Room";

        protected override Constructor<Room> GetCreatingConstructor() => new RoomConstructor(GetNewId());

        protected override Constructor<Room> GetEditingConstructor(Room editableItem) => new RoomConstructor(editableItem);

        protected override ListViewItem GetListViewItem(Room item)
        {
            ListViewItem newItem = new ListViewItem($"Номер {item.Number}");
            newItem.Tag = item.Id;
            return newItem;
        }

        protected override bool IsSuitable(Room room) => room.Hotel == Administrator.Authorized.Hotel;
    }
}
