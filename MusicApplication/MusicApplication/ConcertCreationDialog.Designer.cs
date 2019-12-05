namespace MusicApplication
{
    partial class ConcertCreationDialog
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
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._textEntryLabel = new System.Windows.Forms.Label();
            this._datePicker = new System.Windows.Forms.DateTimePicker();
            this._dateLabel = new System.Windows.Forms.Label();
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._locationTextBox = new System.Windows.Forms.TextBox();
            this._locationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(79, 24);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(276, 20);
            this._nameTextBox.TabIndex = 0;
            // 
            // _textEntryLabel
            // 
            this._textEntryLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._textEntryLabel.Location = new System.Drawing.Point(12, 24);
            this._textEntryLabel.Name = "_textEntryLabel";
            this._textEntryLabel.Size = new System.Drawing.Size(61, 23);
            this._textEntryLabel.TabIndex = 1;
            this._textEntryLabel.Text = "Name:";
            this._textEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _datePicker
            // 
            this._datePicker.Location = new System.Drawing.Point(79, 76);
            this._datePicker.Name = "_datePicker";
            this._datePicker.Size = new System.Drawing.Size(210, 20);
            this._datePicker.TabIndex = 2;
            // 
            // _dateLabel
            // 
            this._dateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._dateLabel.Location = new System.Drawing.Point(12, 76);
            this._dateLabel.Name = "_dateLabel";
            this._dateLabel.Size = new System.Drawing.Size(61, 20);
            this._dateLabel.TabIndex = 1;
            this._dateLabel.Text = "Date:";
            this._dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _saveButton
            // 
            this._saveButton.Enabled = false;
            this._saveButton.Location = new System.Drawing.Point(191, 152);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 25);
            this._saveButton.TabIndex = 3;
            this._saveButton.Text = "Save";
            this._saveButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(272, 152);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(83, 25);
            this._cancelButton.TabIndex = 4;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _locationTextBox
            // 
            this._locationTextBox.Location = new System.Drawing.Point(79, 50);
            this._locationTextBox.Name = "_locationTextBox";
            this._locationTextBox.Size = new System.Drawing.Size(276, 20);
            this._locationTextBox.TabIndex = 1;
            // 
            // _locationLabel
            // 
            this._locationLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._locationLabel.Location = new System.Drawing.Point(12, 50);
            this._locationLabel.Name = "_locationLabel";
            this._locationLabel.Size = new System.Drawing.Size(61, 20);
            this._locationLabel.TabIndex = 1;
            this._locationLabel.Text = "Location:";
            this._locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConcertCreationDialog
            // 
            this.AcceptButton = this._saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(367, 189);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._datePicker);
            this.Controls.Add(this._dateLabel);
            this.Controls.Add(this._locationLabel);
            this.Controls.Add(this._textEntryLabel);
            this.Controls.Add(this._locationTextBox);
            this.Controls.Add(this._nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConcertCreationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create a New Concert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label _textEntryLabel;
        private System.Windows.Forms.DateTimePicker _datePicker;
        private System.Windows.Forms.Label _dateLabel;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.TextBox _locationTextBox;
        private System.Windows.Forms.Label _locationLabel;
    }
}