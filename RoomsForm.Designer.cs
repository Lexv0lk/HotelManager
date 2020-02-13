namespace HotelManager
{
    partial class RoomsForm
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
            this._roomListView = new System.Windows.Forms.ListView();
            this._roomAdditionButton = new System.Windows.Forms.Button();
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _roomListView
            // 
            this._roomListView.BackColor = System.Drawing.SystemColors.Control;
            this._roomListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._roomListView.HideSelection = false;
            this._roomListView.Location = new System.Drawing.Point(-1, 1);
            this._roomListView.MultiSelect = false;
            this._roomListView.Name = "_roomListView";
            this._roomListView.Size = new System.Drawing.Size(800, 403);
            this._roomListView.TabIndex = 1;
            this._roomListView.UseCompatibleStateImageBehavior = false;
            this._roomListView.View = System.Windows.Forms.View.List;
            // 
            // _roomAdditionButton
            // 
            this._roomAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._roomAdditionButton.Location = new System.Drawing.Point(12, 410);
            this._roomAdditionButton.Name = "_roomAdditionButton";
            this._roomAdditionButton.Size = new System.Drawing.Size(217, 37);
            this._roomAdditionButton.TabIndex = 2;
            this._roomAdditionButton.Text = "Добавить номер";
            this._roomAdditionButton.UseVisualStyleBackColor = true;
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
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._roomAdditionButton);
            this.Controls.Add(this._roomListView);
            this.Name = "RoomsForm";
            this.Text = "RoomsForm";
            this._contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _roomListView;
        private System.Windows.Forms.Button _roomAdditionButton;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _deleteStripMenuItem;
    }
}