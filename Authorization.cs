using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class Authorization : Form
    {
        private int _triesLeft = 3;
        private int _timeLeft = 60;
        private bool _timerEnabled = false;

        public Authorization()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string login = _loginTextBox.Text;
            string password = _passwordTextBox.Text;

            foreach (var user in UserDatabase.Users)
                if (user.TryLogin(login, password))
                    ShowMenu(user);

            _triesLeft--;
            if (_triesLeft <= 0)
                EnableTimer();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            if (HasTimerKey())
            {
                _timeLeft = GetTimerKey();
                if (_timeLeft > 0)
                    EnableTimer();
                else
                    _timeLeft = 60;
            }
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_timerEnabled)
                SaveTimer();
        }

        private void TriesTimer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            UpdateTimerLabel();

            if (_timeLeft == 0)
                DisableTimer();
        }

        private void ShowMenu(User user)
        {
            Menu menu = new Menu(user);

            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = Location;
            menu.Size = Size;

            menu.FormClosed += (x, y) => Close();

            menu.Show();
            Hide();
        }

        private void EnableTimer()
        {
            SaveTimer();
            _triesTimer.Start();

            UpdateTimerLabel();
            _timerLabel.Visible = true;
            _warning.Visible = true;
            _enterButton.Enabled = false;

            _timerEnabled = true;
        }

        private void DisableTimer()
        {
            _triesTimer.Stop();
            SaveTimer();

            _timerLabel.Visible = false;
            _warning.Visible = false;
            _enterButton.Enabled = true;

            _triesLeft = 3;
            _timeLeft = 60;
            _timerEnabled = false;
        }

        private void SaveTimer()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey timerKey;
            if (HasTimerKey())
                timerKey = currentUserKey.OpenSubKey("TimerKey", true);
            else
                timerKey = currentUserKey.CreateSubKey("TimerKey");
            timerKey.SetValue("TimeLeft", _timeLeft);
            timerKey.Close();
        }

        private void UpdateTimerLabel()
        {
            int minutes = _timeLeft / 60;
            int seconds = _timeLeft % 60;
            string secondsString = seconds < 10 ? "0" + seconds : seconds.ToString();

            _timerLabel.Text = minutes + ":" + secondsString;
        }

        private bool HasTimerKey() => Registry.CurrentUser.GetSubKeyNames().Any(x => x == "TimerKey");

        private int GetTimerKey() => (int)Registry.CurrentUser.OpenSubKey("TimerKey").GetValue("TimeLeft");
    }
}
