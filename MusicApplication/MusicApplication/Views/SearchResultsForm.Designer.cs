namespace MusicApplication
{
    partial class SearchResultsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._songGrid = new System.Windows.Forms.DataGridView();
            this.songSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._artistGrid = new System.Windows.Forms.DataGridView();
            this.artistSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._albumGrid = new System.Windows.Forms.DataGridView();
            this.albumSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this._title = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._songGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._artistGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._albumGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumSearchBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._albumGrid);
            this.groupBox1.Controls.Add(this._artistGrid);
            this.groupBox1.Controls.Add(this._songGrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 376);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // _songGrid
            // 
            this._songGrid.AutoGenerateColumns = false;
            this._songGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._songGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ArtistString,
            this.dataGridViewTextBoxColumn5});
            this._songGrid.DataSource = this.songSearchBindingSource;
            this._songGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._songGrid.Location = new System.Drawing.Point(3, 19);
            this._songGrid.Name = "_songGrid";
            this._songGrid.Size = new System.Drawing.Size(784, 354);
            this._songGrid.TabIndex = 5;
            // 
            // songSearchBindingSource
            // 
            this.songSearchBindingSource.DataSource = typeof(MusicApplication.Data.Song);
            // 
            // _artistGrid
            // 
            this._artistGrid.AutoGenerateColumns = false;
            this._artistGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._artistGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this._artistGrid.DataSource = this.artistSearchBindingSource;
            this._artistGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._artistGrid.Location = new System.Drawing.Point(3, 19);
            this._artistGrid.Name = "_artistGrid";
            this._artistGrid.Size = new System.Drawing.Size(784, 354);
            this._artistGrid.TabIndex = 4;
            // 
            // artistSearchBindingSource
            // 
            this.artistSearchBindingSource.DataSource = typeof(MusicApplication.Data.Artist);
            // 
            // _albumGrid
            // 
            this._albumGrid.AutoGenerateColumns = false;
            this._albumGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._albumGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this._albumGrid.DataSource = this.albumSearchBindingSource;
            this._albumGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._albumGrid.Location = new System.Drawing.Point(3, 19);
            this._albumGrid.MultiSelect = false;
            this._albumGrid.Name = "_albumGrid";
            this._albumGrid.ReadOnly = true;
            this._albumGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._albumGrid.Size = new System.Drawing.Size(784, 354);
            this._albumGrid.TabIndex = 3;
            // 
            // albumSearchBindingSource
            // 
            this.albumSearchBindingSource.DataSource = typeof(MusicApplication.Data.Album);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 64);
            this.panel2.TabIndex = 6;
            // 
            // _title
            // 
            this._title.Dock = System.Windows.Forms.DockStyle.Fill;
            this._title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._title.Location = new System.Drawing.Point(0, 0);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(790, 64);
            this._title.TabIndex = 0;
            this._title.Text = "Search Results";
            this._title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SongId";
            this.dataGridViewTextBoxColumn1.HeaderText = "SongId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 77;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SongName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Song";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // ArtistString
            // 
            this.ArtistString.DataPropertyName = "ArtistString";
            this.ArtistString.HeaderText = "Artist";
            this.ArtistString.Name = "ArtistString";
            this.ArtistString.ReadOnly = true;
            this.ArtistString.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Length";
            this.dataGridViewTextBoxColumn5.HeaderText = "Length";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ArtistId";
            this.dataGridViewTextBoxColumn9.HeaderText = "ArtistId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 76;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ArtistName";
            this.dataGridViewTextBoxColumn10.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 500;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AlbumId";
            this.dataGridViewTextBoxColumn6.HeaderText = "AlbumId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 83;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AlbumName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Album";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 400;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ReleaseDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Release Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // SearchResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SearchResultsForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._songGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._artistGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._albumGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumSearchBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.DataGridView _albumGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView _songGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView _artistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource albumSearchBindingSource;
        private System.Windows.Forms.BindingSource artistSearchBindingSource;
        private System.Windows.Forms.BindingSource songSearchBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistString;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}