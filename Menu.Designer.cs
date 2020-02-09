namespace HotelManager
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._guestsButton = new System.Windows.Forms.Button();
            this._roomsButton = new System.Windows.Forms.Button();
            this._settlementButton = new System.Windows.Forms.Button();
            this._deportationButton = new System.Windows.Forms.Button();
            this._adminsButton = new System.Windows.Forms.Button();
            this._hotelsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _guestsButton
            // 
            this._guestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._guestsButton.Location = new System.Drawing.Point(256, 138);
            this._guestsButton.Name = "_guestsButton";
            this._guestsButton.Size = new System.Drawing.Size(280, 42);
            this._guestsButton.TabIndex = 0;
            this._guestsButton.Text = "Постояльцы";
            this._guestsButton.UseVisualStyleBackColor = true;
            this._guestsButton.Visible = false;
            // 
            // _roomsButton
            // 
            this._roomsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._roomsButton.Location = new System.Drawing.Point(256, 186);
            this._roomsButton.Name = "_roomsButton";
            this._roomsButton.Size = new System.Drawing.Size(280, 42);
            this._roomsButton.TabIndex = 1;
            this._roomsButton.Text = "Номера";
            this._roomsButton.UseVisualStyleBackColor = true;
            this._roomsButton.Visible = false;
            // 
            // _settlementButton
            // 
            this._settlementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._settlementButton.Location = new System.Drawing.Point(256, 234);
            this._settlementButton.Name = "_settlementButton";
            this._settlementButton.Size = new System.Drawing.Size(280, 42);
            this._settlementButton.TabIndex = 2;
            this._settlementButton.Text = "Заселение";
            this._settlementButton.UseVisualStyleBackColor = true;
            this._settlementButton.Visible = false;
            // 
            // _deportationButton
            // 
            this._deportationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._deportationButton.Location = new System.Drawing.Point(256, 282);
            this._deportationButton.Name = "_deportationButton";
            this._deportationButton.Size = new System.Drawing.Size(280, 42);
            this._deportationButton.TabIndex = 3;
            this._deportationButton.Text = "Выселение";
            this._deportationButton.UseVisualStyleBackColor = true;
            this._deportationButton.Visible = false;
            // 
            // _adminsButton
            // 
            this._adminsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this._adminsButton.Location = new System.Drawing.Point(256, 186);
            this._adminsButton.Name = "_adminsButton";
            this._adminsButton.Size = new System.Drawing.Size(280, 42);
            this._adminsButton.TabIndex = 4;
            this._adminsButton.Text = "Администраторы";
            this._adminsButton.UseVisualStyleBackColor = true;
            this._adminsButton.Visible = false;
            // 
            // _hotelsButton
            // 
            this._hotelsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this._hotelsButton.Location = new System.Drawing.Point(256, 234);
            this._hotelsButton.Name = "_hotelsButton";
            this._hotelsButton.Size = new System.Drawing.Size(280, 42);
            this._hotelsButton.TabIndex = 5;
            this._hotelsButton.Text = "Гостиницы";
            this._hotelsButton.UseVisualStyleBackColor = true;
            this._hotelsButton.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._hotelsButton);
            this.Controls.Add(this._adminsButton);
            this.Controls.Add(this._deportationButton);
            this.Controls.Add(this._settlementButton);
            this.Controls.Add(this._roomsButton);
            this.Controls.Add(this._guestsButton);
            this.Name = "Menu";
            this.Text = "HotelManager";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _guestsButton;
        private System.Windows.Forms.Button _roomsButton;
        private System.Windows.Forms.Button _settlementButton;
        private System.Windows.Forms.Button _deportationButton;
        private System.Windows.Forms.Button _adminsButton;
        private System.Windows.Forms.Button _hotelsButton;
    }
}