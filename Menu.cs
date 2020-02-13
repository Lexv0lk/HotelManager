using System;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class Menu : Form
    {
        public Menu(Role authorizedUserRole)
        {
            InitializeComponent();

            _role = authorizedUserRole;
            _items = new MenuItem[]
            {
                new MenuItem(new GuestsForm(), this, Role.Administrator, _guestsButton),
                new MenuItem(new AdministratorsForm(), this, Role.Manager, _adminsButton),
                new MenuItem(new HotelsForm(), this, Role.Manager, _hotelsButton),
                new MenuItem(new Form(), this, Role.Administrator, _roomsButton),
                new MenuItem(new Form(), this, Role.Administrator, _settlementButton),
                new MenuItem(new Form(), this, Role.Administrator, _deportationButton)
            };
        }

        private Role _role;
        private MenuItem[] _items;

        private void Menu_Load(object sender, EventArgs e)
        {
            foreach (var item in _items)
                item.TryShowButton(_role);
            MessageBox.Show($"Вы авторизовались под ролью {GetRoleName(_role)}", "Напоминание", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
