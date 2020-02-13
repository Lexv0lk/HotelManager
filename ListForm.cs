using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelManager
{
    public abstract class ListForm<Item> : Form where Item : class, IIdentifiable
    {
        protected abstract ListView ListView { get; }
        protected abstract List<Item> ItemList { get; }
        protected abstract ContextMenuStrip MenuStrip { get; }
        protected abstract ToolStripMenuItem DeleteStripMenuItem { get; }
        protected abstract string KeyStart { get; }

        protected void GuestsForm_FormClosing(object sender, EventArgs e)
        {
            Database.Save();
        }

        protected void GuestsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ItemList.Count; i++)
            {
                if (IsSuitable(ItemList[i]) == false)
                    continue;

                ListView.Items.Add(GetListViewItem(ItemList[i]));
            }
        }

        private void OpenForm(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = Location;
            form.Size = Size;

            form.FormClosed += (x, y) => Show();

            form.Show();
            Hide();
        }

        protected void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            ListViewHitTestInfo hit = ListView.HitTest(e.Location);
            if (hit.Item == null)
                return;

            MenuStrip.Show(ListView, e.Location, ToolStripDropDownDirection.BelowRight);
        }

        protected void DeleteStripMenuItem_Click(object sender, EventArgs e)
        {
            Item item = ItemList.First(x => x.Id == (int)ListView.SelectedItems[0].Tag);
            ItemList.Remove(item);
            ListView.Items.Remove(ListView.SelectedItems[0]);

            if (Registry.CurrentUser.GetSubKeyNames().Contains($"{KeyStart}{item.Id}"))
                Registry.CurrentUser.DeleteSubKey($"{KeyStart}{item.Id}");
        }

        protected void GuestListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = ListView.HitTest(e.Location);
            if (hit.Item != null)
            {
                Constructor<Item> constructor = GetEditingConstructor(ItemList.First(x => x.Id == (int)hit.Item.Tag));
                OpenForm(constructor);
            }
        }

        public void ConfirmButton_Click(object sender, EventArgs e)
        {
            Constructor<Item> constructor = GetCreatingConstructor();
            constructor.ItemCreated += OnItemCreated;

            OpenForm(constructor);
        }

        private void OnItemCreated(Item item)
        {
            ItemList.Add(item);
            ListView.Items.Add(GetListViewItem(item));
            Show();
        }

        protected int GetNewId()
        {
            int lastId = 0;
            if (ItemList.Count > 0)
                lastId = ItemList.OrderBy(x => x.Id).Last().Id;

            return ++lastId;
        }

        protected abstract ListViewItem GetListViewItem(Item item);

        protected abstract Constructor<Item> GetCreatingConstructor();

        protected abstract Constructor<Item> GetEditingConstructor(Item editableItem);

        protected abstract bool IsSuitable(Item item);
    }
}
