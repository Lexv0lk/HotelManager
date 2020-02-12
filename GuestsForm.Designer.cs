namespace HotelManager
{
    partial class GuestsForm
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
            this._guestListView = new System.Windows.Forms.ListView();
            this._guestAdditionButton = new System.Windows.Forms.Button();
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _guestListView
            // 
            this._guestListView.BackColor = System.Drawing.SystemColors.Control;
            this._guestListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._guestListView.HideSelection = false;
            this._guestListView.Location = new System.Drawing.Point(0, 0);
            this._guestListView.MultiSelect = false;
            this._guestListView.Name = "_guestListView";
            this._guestListView.Size = new System.Drawing.Size(800, 403);
            this._guestListView.TabIndex = 0;
            this._guestListView.UseCompatibleStateImageBehavior = false;
            this._guestListView.View = System.Windows.Forms.View.List;
            this._guestListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseClick);
            this._guestListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GuestListView_MouseDoubleClick);
            // 
            // _guestAdditionButton
            // 
            this._guestAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._guestAdditionButton.Location = new System.Drawing.Point(12, 409);
            this._guestAdditionButton.Name = "_guestAdditionButton";
            this._guestAdditionButton.Size = new System.Drawing.Size(217, 37);
            this._guestAdditionButton.TabIndex = 1;
            this._guestAdditionButton.Text = "Добавить постояльца";
            this._guestAdditionButton.UseVisualStyleBackColor = true;
            this._guestAdditionButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._deleteStripMenuItem});
            this._contextMenuStrip.Name = "contextMenuStrip1";
            this._contextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // _deleteStripMenuItem
            // 
            this._deleteStripMenuItem.Name = "_deleteStripMenuItem";
            this._deleteStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this._deleteStripMenuItem.Text = "Удалить";
            this._deleteStripMenuItem.Click += new System.EventHandler(this.DeleteStripMenuItem_Click);
            // 
            // GuestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._guestAdditionButton);
            this.Controls.Add(this._guestListView);
            this.Name = "GuestsForm";
            this.Text = "Постояльцы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestsForm_FormClosing);
            this.Load += new System.EventHandler(this.GuestsForm_Load);
            this._contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _guestListView;
        private System.Windows.Forms.Button _guestAdditionButton;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _deleteStripMenuItem;
    }
}