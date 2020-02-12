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
    public partial class Menu : Form
    {
        public Menu(User authorizedUser)
        {
            InitializeComponent();

            _user = authorizedUser;
            _items = new MenuItem[]
            {
                new MenuItem(new GuestsForm(), this, Role.Administrator, _guestsButton),
                new MenuItem(new Form(), this, Role.Manager, _adminsButton),
                new MenuItem(new Form(), this, Role.Manager, _hotelsButton),
                new MenuItem(new Form(), this, Role.Administrator, _roomsButton),
                new MenuItem(new Form(), this, Role.Administrator, _settlementButton),
                new MenuItem(new Form(), this, Role.Administrator, _deportationButton)
            };
        }

        private User _user;
        private MenuItem[] _items;

        private void Menu_Load(object sender, EventArgs e)
        {
            foreach (var item in _items)
                item.TryShowButton(_user);
            MessageBox.Show($"Вы авторизовались под ролью {GetRoleName(_user.Role)}", "Напоминание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetRoleName(Role role)
        {
            if (role == Role.Administrator)
                return "Администратор гостиницы";
            else
                return "Управляющий сети гостиниц";
        }
    }
}
