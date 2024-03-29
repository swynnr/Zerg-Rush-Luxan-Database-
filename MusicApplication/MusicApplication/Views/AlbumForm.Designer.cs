﻿namespace MusicApplication
{
    partial class AlbumForm
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
            this._grid = new System.Windows.Forms.DataGridView();
            this.songIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _grid
            // 
            this._grid.AllowUserToAddRows = false;
            this._grid.AllowUserToDeleteRows = false;
            this._grid.AllowUserToOrderColumns = true;
            this._grid.AllowUserToResizeRows = false;
            this._grid.AutoGenerateColumns = false;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIdDataGridViewTextBoxColumn,
            this.songNameDataGridViewTextBoxColumn,
            this.ArtistString,
            this.lengthDataGridViewTextBoxColumn});
            this._grid.DataMember = "Songs";
            this._grid.DataSource = this.songModelBindingSource;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.Location = new System.Drawing.Point(3, 18);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            this._grid.RowHeadersVisible = false;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(784, 355);
            this._grid.TabIndex = 3;
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
            this.songNameDataGridViewTextBoxColumn.HeaderText = "Song";
            this.songNameDataGridViewTextBoxColumn.Name = "songNameDataGridViewTextBoxColumn";
            this.songNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.songNameDataGridViewTextBoxColumn.Width = 250;
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
            this.lengthDataGridViewTextBoxColumn.Width = 130;
            // 
            // songModelBindingSource
            // 
            this.songModelBindingSource.DataSource = typeof(MusicApplication.SongModel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._grid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 376);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Songs";
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
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 64);
            this.panel2.TabIndex = 4;
            // 
            // _title
            // 
            this._title.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.songModelBindingSource, "SelectedAlbum", true));
            this._title.Dock = System.Windows.Forms.DockStyle.Fill;
            this._title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._title.Location = new System.Drawing.Point(0, 0);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(790, 64);
            this._title.TabIndex = 0;
            this._title.Text = "Album Name";
            this._title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panel1);
            this.Name = "AlbumForm";
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView _grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.BindingSource songModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistString;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
    }
}

