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
            this.tabControl = new System.Windows.Forms.TabControl();
            this._searchTab = new System.Windows.Forms.TabPage();
            this._contentPanel = new System.Windows.Forms.Panel();
            this._searchPanel = new System.Windows.Forms.Panel();
            this._typeSelectorCombo = new System.Windows.Forms.ComboBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._searchTextBox = new System.Windows.Forms.TextBox();
            this._playlistTab = new System.Windows.Forms.TabPage();
            this._concertTab = new System.Windows.Forms.TabPage();
            this._mainPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this._searchTab.SuspendLayout();
            this._searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainPanel
            // 
            this._mainPanel.Controls.Add(this.tabControl);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(0, 0);
            this._mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this._mainPanel.Size = new System.Drawing.Size(1131, 740);
            this._mainPanel.TabIndex = 5;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this._searchTab);
            this.tabControl.Controls.Add(this._playlistTab);
            this.tabControl.Controls.Add(this._concertTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1115, 724);
            this.tabControl.TabIndex = 0;
            // 
            // _searchTab
            // 
            this._searchTab.Controls.Add(this._contentPanel);
            this._searchTab.Controls.Add(this._searchPanel);
            this._searchTab.Location = new System.Drawing.Point(4, 29);
            this._searchTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._searchTab.Name = "_searchTab";
            this._searchTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._searchTab.Size = new System.Drawing.Size(1107, 691);
            this._searchTab.TabIndex = 0;
            this._searchTab.Text = "Search";
            this._searchTab.UseVisualStyleBackColor = true;
            // 
            // _contentPanel
            // 
            this._contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentPanel.Location = new System.Drawing.Point(4, 90);
            this._contentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._contentPanel.Name = "_contentPanel";
            this._contentPanel.Size = new System.Drawing.Size(1099, 596);
            this._contentPanel.TabIndex = 6;
            // 
            // _searchPanel
            // 
            this._searchPanel.Controls.Add(this._typeSelectorCombo);
            this._searchPanel.Controls.Add(this._searchButton);
            this._searchPanel.Controls.Add(this._searchTextBox);
            this._searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._searchPanel.Location = new System.Drawing.Point(4, 5);
            this._searchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._searchPanel.Name = "_searchPanel";
            this._searchPanel.Size = new System.Drawing.Size(1099, 85);
            this._searchPanel.TabIndex = 5;
            this._searchPanel.Text = "Search Artists, Songs, Albums";
            // 
            // _typeSelectorCombo
            // 
            this._typeSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._typeSelectorCombo.FormattingEnabled = true;
            this._typeSelectorCombo.Location = new System.Drawing.Point(22, 32);
            this._typeSelectorCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._typeSelectorCombo.Name = "_typeSelectorCombo";
            this._typeSelectorCombo.Size = new System.Drawing.Size(180, 28);
            this._typeSelectorCombo.TabIndex = 5;
            // 
            // _searchButton
            // 
            this._searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._searchButton.Location = new System.Drawing.Point(920, 32);
            this._searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(168, 35);
            this._searchButton.TabIndex = 4;
            this._searchButton.Text = "Search";
            this._searchButton.UseVisualStyleBackColor = true;
            // 
            // _searchTextBox
            // 
            this._searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchTextBox.Location = new System.Drawing.Point(213, 34);
            this._searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._searchTextBox.Name = "_searchTextBox";
            this._searchTextBox.Size = new System.Drawing.Size(696, 26);
            this._searchTextBox.TabIndex = 1;
            // 
            // _playlistTab
            // 
            this._playlistTab.Location = new System.Drawing.Point(4, 29);
            this._playlistTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._playlistTab.Name = "_playlistTab";
            this._playlistTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._playlistTab.Size = new System.Drawing.Size(1108, 692);
            this._playlistTab.TabIndex = 1;
            this._playlistTab.Text = "Playlists";
            this._playlistTab.UseVisualStyleBackColor = true;
            // 
            // _concertTab
            // 
            this._concertTab.Location = new System.Drawing.Point(4, 29);
            this._concertTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._concertTab.Name = "_concertTab";
            this._concertTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._concertTab.Size = new System.Drawing.Size(1108, 692);
            this._concertTab.TabIndex = 2;
            this._concertTab.Text = "Concerts";
            this._concertTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 740);
            this.Controls.Add(this._mainPanel);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1144, 770);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Music Application";
            this._mainPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this._searchTab.ResumeLayout(false);
            this._searchPanel.ResumeLayout(false);
            this._searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.Panel _contentPanel;
        private System.Windows.Forms.Panel _searchPanel;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.TextBox _searchTextBox;
        private System.Windows.Forms.ComboBox _typeSelectorCombo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage _searchTab;
        private System.Windows.Forms.TabPage _playlistTab;
        private System.Windows.Forms.TabPage _concertTab;
    }
}

