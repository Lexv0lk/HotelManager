namespace HotelManager
{
    partial class AdministratorsForm
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
            this._adminListView = new System.Windows.Forms.ListView();
            this._adminAdditionButton = new System.Windows.Forms.Button();
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _adminListView
            // 
            this._adminListView.BackColor = System.Drawing.SystemColors.Control;
            this._adminListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._adminListView.HideSelection = false;
            this._adminListView.Location = new System.Drawing.Point(0, 0);
            this._adminListView.MultiSelect = false;
            this._adminListView.Name = "_adminListView";
            this._adminListView.Size = new System.Drawing.Size(800, 405);
            this._adminListView.TabIndex = 2;
            this._adminListView.UseCompatibleStateImageBehavior = false;
            this._adminListView.View = System.Windows.Forms.View.List;
            // 
            // _adminAdditionButton
            // 
            this._adminAdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._adminAdditionButton.Location = new System.Drawing.Point(12, 411);
            this._adminAdditionButton.Name = "_adminAdditionButton";
            this._adminAdditionButton.Size = new System.Drawing.Size(217, 37);
            this._adminAdditionButton.TabIndex = 3;
            this._adminAdditionButton.Text = "Добавить администратора";
            this._adminAdditionButton.UseVisualStyleBackColor = true;
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
            // 
            // AdministratorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._adminAdditionButton);
            this.Controls.Add(this._adminListView);
            this.Name = "AdministratorsForm";
            this.Text = "AdministratorsForm";
            this._contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _adminListView;
        private System.Windows.Forms.Button _adminAdditionButton;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _deleteStripMenuItem;
    }
}