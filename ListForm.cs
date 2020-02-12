using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            SaveList();
        }

        protected void GuestsForm_Load(object sender, EventArgs e)
        {
            LoadList();
            for (int i = 0; i < ItemList.Count; i++)
                ListView.Items.Add(GetListViewItem(ItemList[i]));
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

        private void LoadList()
        {
            string[] keyNames = Registry.CurrentUser.GetSubKeyNames()
                                                .Where(x => x.StartsWith(KeyStart))
                                                .ToArray();
            if (keyNames.Length == 0)
                return;

            foreach (var keyName in keyNames)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName);
                Item item = JsonConvert.DeserializeObject<Item>((string)key.GetValue("Object"));
                ItemList.Add(item);
            }
        }

        private void SaveList()
        {
            string[] existingKeys = Registry.CurrentUser.GetSubKeyNames();
            for (int i = 0; i < ItemList.Count; i++)
            {
                string json = JsonConvert.SerializeObject(ItemList[i]);
                RegistryKey key = GetKey(ItemList[i].Id, existingKeys);
                key.SetValue("Object", json);
                key.Close();
            }
        }

        private RegistryKey GetKey(int id, string[] existingSubKeys)
        {
            if (existingSubKeys.Contains($"{KeyStart}{id}"))
                return Registry.CurrentUser.OpenSubKey($"{KeyStart}{id}", true);
            else
                return Registry.CurrentUser.CreateSubKey($"{KeyStart}{id}");
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
    }
}
