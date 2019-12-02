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
            this.albumBindingList = new System.Windows.Forms.BindingSource(this.components);
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistBindingList = new System.Windows.Forms.BindingSource(this.components);
            this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songBindingList = new System.Windows.Forms.BindingSource(this.components);
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._albumGrid = new System.Windows.Forms.DataGridView();
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._artistGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._songGrid = new System.Windows.Forms.DataGridView();
            this.songIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this._title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._albumGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._artistGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._songGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // albumBindingList
            // 
            this.albumBindingList.DataMember = "SearchResultsList";
            this.albumBindingList.DataSource = this.albumBindingSource;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(MusicApplication.SearchModel<MusicApplication.Data.Album>);
            // 
            // artistBindingList
            // 
            this.artistBindingList.DataMember = "SearchResultsList";
            this.artistBindingList.DataSource = this.artistBindingSource;
            // 
            // artistBindingSource
            // 
            this.artistBindingSource.DataSource = typeof(MusicApplication.SearchModel<MusicApplication.Data.Artist>);
            // 
            // songBindingList
            // 
            this.songBindingList.DataMember = "SearchResultsList";
            this.songBindingList.DataSource = this.songBindingSource;
            // 
            // songBindingSource
            // 
            this.songBindingSource.DataSource = typeof(MusicApplication.SearchModel<MusicApplication.Data.Song>);
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
            // _albumGrid
            // 
            this._albumGrid.AutoGenerateColumns = false;
            this._albumGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._albumGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albumIdDataGridViewTextBoxColumn,
            this.albumNameDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn});
            this._albumGrid.DataSource = this.albumBindingList;
            this._albumGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._albumGrid.Location = new System.Drawing.Point(3, 19);
            this._albumGrid.Name = "_albumGrid";
            this._albumGrid.Size = new System.Drawing.Size(784, 354);
            this._albumGrid.TabIndex = 3;
            // 
            // albumIdDataGridViewTextBoxColumn
            // 
            this.albumIdDataGridViewTextBoxColumn.DataPropertyName = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn.HeaderText = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn.Name = "albumIdDataGridViewTextBoxColumn";
            // 
            // albumNameDataGridViewTextBoxColumn
            // 
            this.albumNameDataGridViewTextBoxColumn.DataPropertyName = "AlbumName";
            this.albumNameDataGridViewTextBoxColumn.HeaderText = "AlbumName";
            this.albumNameDataGridViewTextBoxColumn.Name = "albumNameDataGridViewTextBoxColumn";
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            // 
            // _artistGrid
            // 
            this._artistGrid.AutoGenerateColumns = false;
            this._artistGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._artistGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this._artistGrid.DataSource = this.artistBindingList;
            this._artistGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._artistGrid.Location = new System.Drawing.Point(3, 19);
            this._artistGrid.Name = "_artistGrid";
            this._artistGrid.Size = new System.Drawing.Size(784, 354);
            this._artistGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ArtistId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ArtistId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ArtistName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ArtistName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // _songGrid
            // 
            this._songGrid.AutoGenerateColumns = false;
            this._songGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._songGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIdDataGridViewTextBoxColumn,
            this.songNameDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn});
            this._songGrid.DataSource = this.songBindingList;
            this._songGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._songGrid.Location = new System.Drawing.Point(3, 19);
            this._songGrid.Name = "_songGrid";
            this._songGrid.Size = new System.Drawing.Size(784, 354);
            this._songGrid.TabIndex = 5;
            // 
            // songIdDataGridViewTextBoxColumn
            // 
            this.songIdDataGridViewTextBoxColumn.DataPropertyName = "SongId";
            this.songIdDataGridViewTextBoxColumn.HeaderText = "SongId";
            this.songIdDataGridViewTextBoxColumn.Name = "songIdDataGridViewTextBoxColumn";
            // 
            // songNameDataGridViewTextBoxColumn
            // 
            this.songNameDataGridViewTextBoxColumn.DataPropertyName = "SongName";
            this.songNameDataGridViewTextBoxColumn.HeaderText = "SongName";
            this.songNameDataGridViewTextBoxColumn.Name = "songNameDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
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
            // SearchResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SearchResultsForm";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._albumGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._artistGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._songGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.DataGridView _albumGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource albumBindingList;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.BindingSource artistBindingList;
        private System.Windows.Forms.BindingSource artistBindingSource;
        private System.Windows.Forms.BindingSource songBindingList;
        private System.Windows.Forms.BindingSource songBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView _songGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView _artistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
    }
}