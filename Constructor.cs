using System;
using System.Windows.Forms;

namespace HotelManager
{
    public abstract class Constructor<Item> : Form
    {
        public abstract event Action<Item> ItemCreated;

        protected void CancelButton_Click(object sender, EventArgs e) => Close();

        protected void DisplayError(string text) => MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
