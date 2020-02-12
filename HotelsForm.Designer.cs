namespace HotelManager
{
    partial class HotelsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this._hotelsListView = new System.Windows.Forms.ListView();
            this._hotelAdditionButton = new System.Windows.Forms.Button();
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._cityTextBox = new System.Windows.Forms.TextBox();
            this._countryTextBox = new System.Windows.Forms.TextBox();
            this._streetTextBox = new System.Windows.Forms.TextBox();
            this._houseTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this._contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label1.Location = new System.Drawing.Point(296, 400);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "Страна:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label2.Location = new System.Drawing.Point(296, 426);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 20);
            label2.TabIndex = 8;
            label2.Text = "Город:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label3.Location = new System.Drawing.Point(576, 399);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Улица:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label4.Location = new System.Drawing.Point(576, 427);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 20);
            label4.TabIndex = 10;
            label4.Text = "Дом:";
            // 
            // _hotelsListView
            // 
            this._hotelsListView.BackColor = System.Drawing.SystemColors.Control;
            this._hotelsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._hotelsListView.HideSelection = false;
            this._hotelsListView.Location = new System.Drawing.Point(0, 1);
            this._hotelsListView.MultiSelect = false;
            this._hotelsListView.Name = "_hotelsListView";
            this._hotelsListView.Size = new System.Drawing.Size(800, 392);
            this._hotelsListView.TabIndex = 1;
            this._hotelsListView.UseCompatibleStateImageBehavior = false;
            this._hotelsListView.View = System.Windows.Forms.View.List;
            // 
            // _hotelAdditionButton
            // 
            this._hotelAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._hotelAdditionButton.Location = new System.Drawing.Point(12, 401);
            this._hotelAdditionButton.Name = "_hotelAdditionButton";
            this._hotelAdditionButton.Size = new System.Drawing.Size(217, 37);
            this._hotelAdditionButton.TabIndex = 2;
            this._hotelAdditionButton.Text = "Добавить гостиницу";
            this._hotelAdditionButton.UseVisualStyleBackColor = true;
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._deleteStripMenuItem});
            this._contextMenuStrip.Name = "contextMenuStrip1";
            this._contextMenuStrip.Size = new System.Drawing.Size(119, 26);
            // 
            // _deleteStripMenuItem
            // 
            this._deleteStripMenuItem.Name = "_deleteStripMenuItem";
            this._deleteStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this._deleteStripMenuItem.Text = "Удалить";
            // 
            // _cityTextBox
            // 
            this._cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._cityTextBox.Location = new System.Drawing.Point(371, 426);
            this._cityTextBox.Name = "_cityTextBox";
            this._cityTextBox.Size = new System.Drawing.Size(146, 21);
            this._cityTextBox.TabIndex = 3;
            // 
            // _countryTextBox
            // 
            this._countryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._countryTextBox.Location = new System.Drawing.Point(371, 399);
            this._countryTextBox.Name = "_countryTextBox";
            this._countryTextBox.Size = new System.Drawing.Size(146, 21);
            this._countryTextBox.TabIndex = 4;
            // 
            // _streetTextBox
            // 
            this._streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._streetTextBox.Location = new System.Drawing.Point(642, 399);
            this._streetTextBox.Name = "_streetTextBox";
            this._streetTextBox.Size = new System.Drawing.Size(146, 21);
            this._streetTextBox.TabIndex = 5;
            // 
            // _houseTextBox
            // 
            this._houseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._houseTextBox.Location = new System.Drawing.Point(642, 426);
            this._houseTextBox.Name = "_houseTextBox";
            this._houseTextBox.Size = new System.Drawing.Size(146, 21);
            this._houseTextBox.TabIndex = 7;
            // 
            // HotelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this._houseTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this._streetTextBox);
            this.Controls.Add(this._countryTextBox);
            this.Controls.Add(this._cityTextBox);
            this.Controls.Add(this._hotelAdditionButton);
            this.Controls.Add(this._hotelsListView);
            this.Name = "HotelsForm";
            this.Text = "Гостиницы";
            this._contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView _hotelsListView;
        private System.Windows.Forms.Button _hotelAdditionButton;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _deleteStripMenuItem;
        private System.Windows.Forms.TextBox _cityTextBox;
        private System.Windows.Forms.TextBox _countryTextBox;
        private System.Windows.Forms.TextBox _streetTextBox;
        private System.Windows.Forms.TextBox _houseTextBox;
    }
}