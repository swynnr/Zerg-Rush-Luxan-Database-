namespace MusicApplication
{
    partial class SongSearchForm
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
            this._searchPanel = new System.Windows.Forms.Panel();
            this._searchButton = new System.Windows.Forms.Button();
            this._searchText = new System.Windows.Forms.TextBox();
            this._groupBox = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.songIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchSongModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._searchPanel.SuspendLayout();
            this._groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchSongModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _searchPanel
            // 
            this._searchPanel.Controls.Add(this._searchButton);
            this._searchPanel.Controls.Add(this._searchText);
            this._searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._searchPanel.Location = new System.Drawing.Point(0, 0);
            this._searchPanel.Name = "_searchPanel";
            this._searchPanel.Size = new System.Drawing.Size(596, 55);
            this._searchPanel.TabIndex = 6;
            this._searchPanel.Text = "Search Artists, Songs, Albums";
            // 
            // _searchButton
            // 
            this._searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._searchButton.Location = new System.Drawing.Point(477, 21);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(112, 23);
            this._searchButton.TabIndex = 1;
            this._searchButton.Text = "Search";
            this._searchButton.UseVisualStyleBackColor = true;
            // 
            // _searchText
            // 
            this._searchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchText.Location = new System.Drawing.Point(12, 22);
            this._searchText.Name = "_searchText";
            this._searchText.Size = new System.Drawing.Size(459, 20);
            this._searchText.TabIndex = 0;
            // 
            // _groupBox
            // 
            this._groupBox.Controls.Add(this.Grid);
            this._groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupBox.Location = new System.Drawing.Point(0, 55);
            this._groupBox.Name = "_groupBox";
            this._groupBox.Size = new System.Drawing.Size(596, 357);
            this._groupBox.TabIndex = 7;
            this._groupBox.TabStop = false;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.AutoGenerateColumns = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIdDataGridViewTextBoxColumn,
            this.songNameDataGridViewTextBoxColumn,
            this.ArtistString,
            this.lengthDataGridViewTextBoxColumn});
            this.Grid.DataMember = "SearchResultsList";
            this.Grid.DataSource = this.searchSongModelBindingSource;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 16);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(590, 338);
            this.Grid.TabIndex = 0;
            // 
            // songIdDataGridViewTextBoxColumn
            // 
            this.songIdDataGridViewTextBoxColumn.DataPropertyName = "SongId";
            this.songIdDataGridViewTextBoxColumn.HeaderText = "SongId";
            this.songIdDataGridViewTextBoxColumn.Name = "songIdDataGridViewTextBoxColumn";
            this.songIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.songIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // songNameDataGridViewTextBoxColumn
            // 
            this.songNameDataGridViewTextBoxColumn.DataPropertyName = "SongName";
            this.songNameDataGridViewTextBoxColumn.HeaderText = "SongName";
            this.songNameDataGridViewTextBoxColumn.Name = "songNameDataGridViewTextBoxColumn";
            this.songNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.songNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // ArtistString
            // 
            this.ArtistString.DataPropertyName = "ArtistString";
            this.ArtistString.HeaderText = "Artist";
            this.ArtistString.Name = "ArtistString";
            this.ArtistString.ReadOnly = true;
            this.ArtistString.Width = 200;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // searchSongModelBindingSource
            // 
            this.searchSongModelBindingSource.DataSource = typeof(MusicApplication.SearchSongModel);
            // 
            // SongSearchForm
            // 
            this.AcceptButton = this._searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 412);
            this.Controls.Add(this._groupBox);
            this.Controls.Add(this._searchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SongSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SongSearchForm";
            this._searchPanel.ResumeLayout(false);
            this._searchPanel.PerformLayout();
            this._groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchSongModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _searchPanel;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.TextBox _searchText;
        private System.Windows.Forms.GroupBox _groupBox;
        public System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.BindingSource searchSongModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistString;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
    }
}