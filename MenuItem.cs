using System;
using System.Windows.Forms;

namespace HotelManager
{
    public class MenuItem
    {
        public MenuItem(Form formToOpen, Form menu, Role necessaryRole, Button button)
        {
            _formToOpen = formToOpen;
            _menu = menu;
            _necessaryRole = necessaryRole;
            _button = button;

            _button.Click += OnButtonClick;
        }

        private Role _necessaryRole;
        private Form _formToOpen;
        private Form _menu;
        private Button _button;

        private void OnButtonClick(object sender, EventArgs e)
        {
            _formToOpen.StartPosition = FormStartPosition.Manual;
            _formToOpen.Location = _menu.Location;
            _formToOpen.Size = _menu.Size;

            _formToOpen.FormClosed += (x, y) => _menu.Show();

            _formToOpen.Show();
            _menu.Hide();
        }

        public bool TryShowButton(User user)
        {
            if (user.Role != _necessaryRole)
                return false;

            _button.Visible = true;
            return true;
        }
    }
}
