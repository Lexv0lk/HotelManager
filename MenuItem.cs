using System.Windows.Forms;

namespace HotelManager
{
    public class MenuItem
    {
        private Role _necessaryRole;
        private Form _formToOpen;
        private Button _button;

        public MenuItem(Form formToOpen, Role necessaryRole, Button button)
        {
            _formToOpen = formToOpen;
            _necessaryRole = necessaryRole;
            _button = button;
        }

        public void ShowForm(Form oldForm)
        {
            _formToOpen.StartPosition = FormStartPosition.Manual;
            _formToOpen.Location = oldForm.Location;
            _formToOpen.Size = oldForm.Size;

            _formToOpen.FormClosed += (x, y) => oldForm.Close();

            _formToOpen.Show();
            oldForm.Hide();
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
