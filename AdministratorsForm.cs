using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class AdministratorsForm : ListForm<Administrator>
    {
        public AdministratorsForm()
        {
            InitializeComponent();
        }

        protected override ListView ListView => _adminListView;
        protected override List<Administrator> ItemList => Database.Administrators;
        protected override ContextMenuStrip MenuStrip => _contextMenuStrip;
        protected override ToolStripMenuItem DeleteStripMenuItem => _deleteStripMenuItem;
        protected override string KeyStart => "Admin";

        protected override Constructor<Administrator> GetCreatingConstructor() => new AdministratorConstructor(GetNewId());

        protected override Constructor<Administrator> GetEditingConstructor(Administrator editableItem) => new AdministratorConstructor(editableItem);

        protected override ListViewItem GetListViewItem(Administrator admin)
        {
            ListViewItem listViewItem = new ListViewItem($"{admin.Name} {admin.Surname} {admin.MiddleName}");
            listViewItem.Tag = admin.Id;
            return listViewItem;
        }

        protected override bool IsSuitable(Administrator item) => true;
    }
}
