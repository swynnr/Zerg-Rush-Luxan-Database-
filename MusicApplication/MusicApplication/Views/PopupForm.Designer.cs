﻿namespace MusicApplication.Views
{
    partial class PopupForm
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
            this._popupFormButtonOK = new System.Windows.Forms.Button();
            this._popupFormDialog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _popupFormButtonOK
            // 
            this._popupFormButtonOK.Location = new System.Drawing.Point(87, 59);
            this._popupFormButtonOK.Name = "_popupFormButtonOK";
            this._popupFormButtonOK.Size = new System.Drawing.Size(75, 23);
            this._popupFormButtonOK.TabIndex = 0;
            this._popupFormButtonOK.Text = "OK";
            this._popupFormButtonOK.UseVisualStyleBackColor = true;
            this._popupFormButtonOK.Click += new System.EventHandler(this.popupButtonClose);
            // 
            // _popupFormDialog
            // 
            this._popupFormDialog.AutoSize = true;
            this._popupFormDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._popupFormDialog.Location = new System.Drawing.Point(100, 36);
            this._popupFormDialog.Name = "_popupFormDialog";
            this._popupFormDialog.Size = new System.Drawing.Size(0, 17);
            this._popupFormDialog.TabIndex = 1;
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 94);
            this.Controls.Add(this._popupFormDialog);
            this.Controls.Add(this._popupFormButtonOK);
            this.Name = "PopupForm";
            this.Text = "PopupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _popupFormButtonOK;
        private System.Windows.Forms.Label _popupFormDialog;
    }
}