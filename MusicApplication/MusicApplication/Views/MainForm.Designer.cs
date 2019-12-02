namespace MusicApplication
{
    partial class MainForm
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
            this._mainPanel = new System.Windows.Forms.Panel();
            this._contentPanel = new System.Windows.Forms.Panel();
            this._searchPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._searchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this._searchTab = new System.Windows.Forms.TabPage();
            this._playlistTab = new System.Windows.Forms.TabPage();
            this._concertTab = new System.Windows.Forms.TabPage();
            this._mainPanel.SuspendLayout();
            this._contentPanel.SuspendLayout();
            this._searchPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this._searchTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainPanel
            // 
            this._mainPanel.Controls.Add(this.tabControl);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(0, 0);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Padding = new System.Windows.Forms.Padding(5);
            this._mainPanel.Size = new System.Drawing.Size(754, 481);
            this._mainPanel.TabIndex = 5;
            // 
            // _contentPanel
            // 
            this._contentPanel.Controls.Add(this._searchPanel);
            this._contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentPanel.Location = new System.Drawing.Point(3, 3);
            this._contentPanel.Name = "_contentPanel";
            this._contentPanel.Size = new System.Drawing.Size(730, 439);
            this._contentPanel.TabIndex = 6;
            // 
            // _searchPanel
            // 
            this._searchPanel.Controls.Add(this.comboBox1);
            this._searchPanel.Controls.Add(this._searchButton);
            this._searchPanel.Controls.Add(this.textBox1);
            this._searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._searchPanel.Location = new System.Drawing.Point(0, 0);
            this._searchPanel.Name = "_searchPanel";
            this._searchPanel.Size = new System.Drawing.Size(730, 55);
            this._searchPanel.TabIndex = 5;
            this._searchPanel.Text = "Search Artists, Songs, Albums";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // _searchButton
            // 
            this._searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._searchButton.Location = new System.Drawing.Point(611, 21);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(112, 23);
            this._searchButton.TabIndex = 4;
            this._searchButton.Text = "Search";
            this._searchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(142, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(463, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this._searchTab);
            this.tabControl.Controls.Add(this._playlistTab);
            this.tabControl.Controls.Add(this._concertTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(5, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(744, 471);
            this.tabControl.TabIndex = 0;
            // 
            // _searchTab
            // 
            this._searchTab.Controls.Add(this._contentPanel);
            this._searchTab.Location = new System.Drawing.Point(4, 22);
            this._searchTab.Name = "_searchTab";
            this._searchTab.Padding = new System.Windows.Forms.Padding(3);
            this._searchTab.Size = new System.Drawing.Size(736, 445);
            this._searchTab.TabIndex = 0;
            this._searchTab.Text = "Search";
            this._searchTab.UseVisualStyleBackColor = true;
            // 
            // _playlistTab
            // 
            this._playlistTab.Location = new System.Drawing.Point(4, 22);
            this._playlistTab.Name = "_playlistTab";
            this._playlistTab.Padding = new System.Windows.Forms.Padding(3);
            this._playlistTab.Size = new System.Drawing.Size(736, 445);
            this._playlistTab.TabIndex = 1;
            this._playlistTab.Text = "Playlists";
            this._playlistTab.UseVisualStyleBackColor = true;
            // 
            // _concertTab
            // 
            this._concertTab.Location = new System.Drawing.Point(4, 22);
            this._concertTab.Name = "_concertTab";
            this._concertTab.Padding = new System.Windows.Forms.Padding(3);
            this._concertTab.Size = new System.Drawing.Size(736, 445);
            this._concertTab.TabIndex = 2;
            this._concertTab.Text = "Concerts";
            this._concertTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 481);
            this.Controls.Add(this._mainPanel);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(770, 520);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Music Application";
            this._mainPanel.ResumeLayout(false);
            this._contentPanel.ResumeLayout(false);
            this._searchPanel.ResumeLayout(false);
            this._searchPanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this._searchTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.Panel _contentPanel;
        private System.Windows.Forms.Panel _searchPanel;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage _searchTab;
        private System.Windows.Forms.TabPage _playlistTab;
        private System.Windows.Forms.TabPage _concertTab;
    }
}

