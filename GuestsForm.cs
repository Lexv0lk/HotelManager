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
    public partial class GuestsForm : Form
    {
        private List<Guest> _guests = new List<Guest>();

        public GuestsForm()
        {
            InitializeComponent();
        }

        private void GuestsForm_Load(object sender, EventArgs e)
        {
            LoadGuests();
            for (int i = 0; i < _guests.Count; i++)
                _guestListView.Items.Add(GetGuestItem(_guests[i]));
        }

        private void GuestAdditionButton_Click(object sender, EventArgs e)
        {
            GuestConstructor guestConstructor = new GuestConstructor(GetNewId());
            guestConstructor.GuestCreated += OnGuestCreated;

            OpenForm(guestConstructor);
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

        private void GuestsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveGuests();
        }

        private void GuestListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = _guestListView.HitTest(e.Location);
            if (hit.Item != null)
            {
                GuestConstructor guestConstructor = new GuestConstructor(_guests.First(x => x.Id == (int)hit.Item.Tag));
                OpenForm(guestConstructor);
            }
        }

        private void OnGuestCreated(Guest guest, GuestConstructor constructor)
        {
            _guests.Add(guest);
            _guestListView.Items.Add(GetGuestItem(guest));
            SaveGuest(guest, GetGuestKey(guest.Id, Registry.CurrentUser.GetSubKeyNames()));
            Show();
        }

        private ListViewItem GetGuestItem(Guest guest)
        {
            ListViewItem guestItem = new ListViewItem($"{guest.Name} {guest.Surname} {guest.MiddleName}");
            guestItem.Tag = guest.Id;
            return guestItem;
        }

        private void SaveGuests()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            string[] existingSubKeys = currentUserKey.GetSubKeyNames();

            if (_guests.Count > 0)
            {
                foreach (var guest in _guests)
                {
                    RegistryKey guestKey = GetGuestKey(guest.Id, existingSubKeys);
                    SaveGuest(guest, guestKey);
                }

                currentUserKey.Close();
            }
        }

        private void LoadGuests()
        {
            string[] guestKeys = Registry.CurrentUser.GetSubKeyNames().Where(x => x.StartsWith("Guest")).ToArray();
            if (guestKeys.Length > 0)
            {
                foreach (var keyName in guestKeys)
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName);
                    _guests.Add(RestoreGuest(key));
                }
            }
        }

        private int GetNewId()
        {
            int lastId = 0;
            if (_guests.Count > 0)
                lastId = _guests.OrderBy(x => x.Id).Last().Id;

            return ++lastId;
        }

        private RegistryKey GetGuestKey(int id, string[] existingSubKeys)
        {
            if (existingSubKeys.Contains($"Guest{id}"))
                return Registry.CurrentUser.OpenSubKey($"Guest{id}", true);
            else
                return Registry.CurrentUser.CreateSubKey($"Guest{id}");
        }

        private void SaveGuest(Guest guest, RegistryKey key)
        {
            key.SetValue("Id", guest.Id);
            key.SetValue("Name", guest.Name);
            key.SetValue("Surname", guest.Surname);
            key.SetValue("MiddleName", guest.MiddleName);
            key.SetValue("BirthDate", guest.BirthDate.Ticks);
            key.SetValue("Gender", guest.Gender);
            key.SetValue("Phone", guest.Phone);
            key.SetValue("PassportSeries", guest.PassportSeries);
            key.SetValue("PassportNumber", guest.PassportNumber);
            key.SetValue("PassportIssueDate", guest.PassportIssueDate.Ticks);
        }

        private Guest RestoreGuest(RegistryKey key)
        {
            string name = (string)key.GetValue("Name");
            string surname = (string)key.GetValue("Surname");
            string middleName = (string)key.GetValue("MiddleName");
            string gender = (string)key.GetValue("Gender");
            string phone = (string)key.GetValue("Phone");

            int id = (int)key.GetValue("Id");
            int passportSeries = (int)key.GetValue("PassportSeries");
            int passportNumber = (int)key.GetValue("PassportNumber");

            DateTime birthDate = new DateTime(long.Parse((string)key.GetValue("BirthDate")));
            DateTime passportIssueDate = new DateTime(long.Parse((string)key.GetValue("PassportIssueDate")));

            return new Guest(id, name, surname, middleName, birthDate, gender, phone, passportSeries, passportNumber, passportIssueDate);
        }

        private void GuestListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            ListViewHitTestInfo hit = _guestListView.HitTest(e.Location);
            if (hit.Item == null)
                return;

            _contextMenuStrip.Show(_guestListView, e.Location, ToolStripDropDownDirection.BelowRight);
        }

        private void DeleteStripMenuItem_Click(object sender, EventArgs e)
        {
            Guest guest = _guests.First(x => x.Id == (int)_guestListView.SelectedItems[0].Tag);
            _guests.Remove(guest);
            _guestListView.Items.Remove(_guestListView.SelectedItems[0]);

            if (Registry.CurrentUser.GetSubKeyNames().Contains($"Guest{guest.Id}"))
            {
                Registry.CurrentUser.DeleteSubKey($"Guest{guest.Id}");
                Registry.CurrentUser.Close();
            }
        }
    }
}
