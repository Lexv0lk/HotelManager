namespace HotelManager
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._loginTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._enterButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._loginLable = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._warning = new System.Windows.Forms.Label();
            this._timerLabel = new System.Windows.Forms.Label();
            this._triesTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // _loginTextBox
            // 
            this._loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._loginTextBox.Location = new System.Drawing.Point(214, 155);
            this._loginTextBox.Name = "_loginTextBox";
            this._loginTextBox.Size = new System.Drawing.Size(327, 26);
            this._loginTextBox.TabIndex = 0;
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._passwordTextBox.Location = new System.Drawing.Point(226, 187);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.Size = new System.Drawing.Size(315, 26);
            this._passwordTextBox.TabIndex = 1;
            // 
            // _enterButton
            // 
            this._enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this._enterButton.Location = new System.Drawing.Point(288, 219);
            this._enterButton.Name = "_enterButton";
            this._enterButton.Size = new System.Drawing.Size(77, 28);
            this._enterButton.TabIndex = 2;
            this._enterButton.Text = "Вход";
            this._enterButton.UseVisualStyleBackColor = true;
            this._enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this._cancelButton.Location = new System.Drawing.Point(371, 219);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(77, 28);
            this._cancelButton.TabIndex = 3;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // _loginLable
            // 
            this._loginLable.AutoSize = true;
            this._loginLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._loginLable.Location = new System.Drawing.Point(149, 158);
            this._loginLable.Name = "_loginLable";
            this._loginLable.Size = new System.Drawing.Size(59, 20);
            this._loginLable.TabIndex = 4;
            this._loginLable.Text = "Логин:";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._passwordLabel.Location = new System.Drawing.Point(149, 190);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(71, 20);
            this._passwordLabel.TabIndex = 5;
            this._passwordLabel.Text = "Пароль:";
            // 
            // _warning
            // 
            this._warning.AutoSize = true;
            this._warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._warning.Location = new System.Drawing.Point(242, 262);
            this._warning.Name = "_warning";
            this._warning.Size = new System.Drawing.Size(263, 40);
            this._warning.TabIndex = 6;
            this._warning.Text = "Вы истратили свои попытки \r\nДо следующих попыток осталось";
            this._warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._warning.Visible = false;
            // 
            // _timerLabel
            // 
            this._timerLabel.AutoSize = true;
            this._timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this._timerLabel.Location = new System.Drawing.Point(340, 302);
            this._timerLabel.Name = "_timerLabel";
            this._timerLabel.Size = new System.Drawing.Size(49, 24);
            this._timerLabel.TabIndex = 7;
            this._timerLabel.Text = "1:00";
            this._timerLabel.Visible = false;
            // 
            // _triesTimer
            // 
            this._triesTimer.Interval = 1000;
            this._triesTimer.Tick += new System.EventHandler(this.TriesTimer_Tick);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._timerLabel);
            this.Controls.Add(this._warning);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._loginLable);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._enterButton);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._loginTextBox);
            this.Name = "Authorization";
            this.Text = "HotelManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _loginTextBox;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Button _enterButton;
        private System.Windows.Forms.Label _loginLable;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _warning;
        private System.Windows.Forms.Label _timerLabel;
        private System.Windows.Forms.Timer _triesTimer;
    }
}

