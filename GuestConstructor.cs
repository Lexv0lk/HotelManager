using System;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class GuestConstructor : Form
    {
        private GuestConstructor()
        {
            InitializeComponent();
        }

        public GuestConstructor(int newId) : this()
        {
            _newId = newId;
            _maleRadioButton.Checked = true;
        }

        public GuestConstructor(Guest guest) : this()
        {
            _guestToChange = guest;
            _finishButton.Text = "Изменить";

            _nameTextBox.Text = _guestToChange.Name;
            _surnameTextBox.Text = _guestToChange.Surname;
            _middleNameTextBox.Text = _guestToChange.MiddleName;
            _phoneTextBox.Text = _guestToChange.Phone;

            _seriesTextBox.Text = _guestToChange.PassportSeries.ToString();
            _numberTextBox.Text = _guestToChange.PassportNumber.ToString();

            if (_guestToChange.Gender == _maleRadioButton.Text)
                _maleRadioButton.Checked = true;
            else
                _femaleRadioButton.Checked = true;

            _birthdatePicker.Value = _guestToChange.BirthDate;
            _issueDatePicker.Value = _guestToChange.PassportIssueDate;
        }

        private int _newId;
        private Guest _guestToChange;

        public Action<Guest, GuestConstructor> GuestCreated;

        private void AddingButton_Click(object sender, EventArgs e)
        {
            string name = _nameTextBox.Text;
            string surname = _surnameTextBox.Text;
            string middleName = _middleNameTextBox.Text;
            string phone = _phoneTextBox.Text;

            if (name == "" || surname == "" || middleName == "" || phone == "" || _seriesTextBox.Text == "" || _numberTextBox.Text == "")
            {
                DisplayError("Не все поля заполнены!");
                return;
            }

            string gender;
            if (_maleRadioButton.Checked)
                gender = _maleRadioButton.Text;
            else
                gender = _femaleRadioButton.Text;
            DateTime birthDate = _birthdatePicker.Value;
            DateTime passportIssueDate = _issueDatePicker.Value;

            int passportSeries;
            int passportNumber;
            if (int.TryParse(_seriesTextBox.Text, out passportSeries) == false)
            {
                DisplayError("Некорректная серия паспорта!");
                return;
            }
            if(int.TryParse(_numberTextBox.Text, out passportNumber) == false)
            {
                DisplayError("Некорректный номер паспорта!");
                return;
            }

            if (_guestToChange == null)
            {
                Guest newGuest = new Guest(_newId, name, surname, middleName, birthDate, gender, phone, passportSeries, passportNumber, passportIssueDate);
                GuestCreated?.Invoke(newGuest, this);
            }
            else
            {
                _guestToChange.Name = name;
                _guestToChange.Surname = surname;
                _guestToChange.MiddleName = middleName;
                _guestToChange.Phone = phone;
                _guestToChange.Gender = gender;
                _guestToChange.BirthDate = birthDate;
                _guestToChange.PassportSeries = passportSeries;
                _guestToChange.PassportNumber = passportNumber;
                _guestToChange.PassportIssueDate = passportIssueDate;
            }

            Close();
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayError(string text) => MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
