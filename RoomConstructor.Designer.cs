namespace HotelManager
{
    partial class RoomConstructor
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this._numberInput = new System.Windows.Forms.NumericUpDown();
            this._roomsInput = new System.Windows.Forms.NumericUpDown();
            this._squareinput = new System.Windows.Forms.NumericUpDown();
            this._confirmButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._numberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._roomsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._squareinput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label1.Location = new System.Drawing.Point(240, 145);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 20);
            label1.TabIndex = 3;
            label1.Text = "Номер:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label2.Location = new System.Drawing.Point(240, 209);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(124, 20);
            label2.TabIndex = 4;
            label2.Text = "Кол-во комнат:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label3.Location = new System.Drawing.Point(240, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Площадь:";
            // 
            // _numberInput
            // 
            this._numberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._numberInput.Location = new System.Drawing.Point(370, 143);
            this._numberInput.Name = "_numberInput";
            this._numberInput.Size = new System.Drawing.Size(211, 26);
            this._numberInput.TabIndex = 0;
            // 
            // _roomsInput
            // 
            this._roomsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._roomsInput.Location = new System.Drawing.Point(370, 207);
            this._roomsInput.Name = "_roomsInput";
            this._roomsInput.Size = new System.Drawing.Size(211, 26);
            this._roomsInput.TabIndex = 1;
            // 
            // _squareinput
            // 
            this._squareinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._squareinput.Location = new System.Drawing.Point(370, 175);
            this._squareinput.Name = "_squareinput";
            this._squareinput.Size = new System.Drawing.Size(211, 26);
            this._squareinput.TabIndex = 2;
            // 
            // _finishButton
            // 
            this._confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._confirmButton.Location = new System.Drawing.Point(248, 384);
            this._confirmButton.Name = "_finishButton";
            this._confirmButton.Size = new System.Drawing.Size(138, 36);
            this._confirmButton.TabIndex = 19;
            this._confirmButton.Text = "Добавить";
            this._confirmButton.UseVisualStyleBackColor = true;
            this._confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._cancelButton.Location = new System.Drawing.Point(392, 384);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(138, 36);
            this._cancelButton.TabIndex = 20;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RoomConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._confirmButton);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this._squareinput);
            this.Controls.Add(this._roomsInput);
            this.Controls.Add(this._numberInput);
            this.Name = "RoomConstructor";
            this.Text = "RoomConstructor";
            ((System.ComponentModel.ISupportInitialize)(this._numberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._roomsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._squareinput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _numberInput;
        private System.Windows.Forms.NumericUpDown _roomsInput;
        private System.Windows.Forms.NumericUpDown _squareinput;
        private System.Windows.Forms.Button _confirmButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}