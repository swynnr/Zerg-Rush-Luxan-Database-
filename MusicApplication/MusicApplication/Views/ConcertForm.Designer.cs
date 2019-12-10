namespace MusicApplication
{
    partial class ConcertForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this._songGrid = new System.Windows.Forms.DataGridView();
            this.concertModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this._artistGrid = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this._deleteSongButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this._concertGrid = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this._newButton = new System.Windows.Forms.Button();
            this._deletePlaylistButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.runtimeVariable = new System.Windows.Forms.Label();
            this.runtimeLabel = new System.Windows.Forms.Label();
            this._title = new System.Windows.Forms.Label();
            this.concertIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._songGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertModelBindingSource)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._artistGrid)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._concertGrid)).BeginInit();
            this.panel6.SuspendLayout();
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
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 376);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._songGrid);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this._artistGrid);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(365, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 355);
            this.panel3.TabIndex = 5;
            // 
            // _songGrid
            // 
            this._songGrid.AutoGenerateColumns = false;
            this._songGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._songGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIdDataGridViewTextBoxColumn,
            this.songNameDataGridViewTextBoxColumn,
            this.ArtistString,
            this.lengthDataGridViewTextBoxColumn});
            this._songGrid.DataMember = "SongList";
            this._songGrid.DataSource = this.concertModelBindingSource;
            this._songGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._songGrid.Location = new System.Drawing.Point(0, 144);
            this._songGrid.Name = "_songGrid";
            this._songGrid.ReadOnly = true;
            this._songGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._songGrid.Size = new System.Drawing.Size(422, 165);
            this._songGrid.TabIndex = 3;
            // 
            // concertModelBindingSource
            // 
            this.concertModelBindingSource.DataSource = typeof(MusicApplication.ConcertModel);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 115);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(422, 29);
            this.panel8.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Song List";
            // 
            // _artistGrid
            // 
            this._artistGrid.AutoGenerateColumns = false;
            this._artistGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._artistGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistIdDataGridViewTextBoxColumn,
            this.artistNameDataGridViewTextBoxColumn});
            this._artistGrid.DataMember = "FeaturedArtists";
            this._artistGrid.DataSource = this.concertModelBindingSource;
            this._artistGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this._artistGrid.Location = new System.Drawing.Point(0, 29);
            this._artistGrid.Name = "_artistGrid";
            this._artistGrid.ReadOnly = true;
            this._artistGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._artistGrid.Size = new System.Drawing.Size(422, 86);
            this._artistGrid.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(422, 29);
            this.panel7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Featured Artists";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this._deleteSongButton);
            this.panel4.Controls.Add(this._addButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 46);
            this.panel4.TabIndex = 4;
            // 
            // _deleteSongButton
            // 
            this._deleteSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._deleteSongButton.Location = new System.Drawing.Point(87, 4);
            this._deleteSongButton.Name = "_deleteSongButton";
            this._deleteSongButton.Size = new System.Drawing.Size(75, 37);
            this._deleteSongButton.TabIndex = 0;
            this._deleteSongButton.Text = "Delete";
            this._deleteSongButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            this._addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addButton.Location = new System.Drawing.Point(6, 4);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 37);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this._concertGrid);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(3, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 355);
            this.panel5.TabIndex = 6;
            // 
            // _concertGrid
            // 
            this._concertGrid.AutoGenerateColumns = false;
            this._concertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._concertGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.concertIdDataGridViewTextBoxColumn,
            this.concertNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this._concertGrid.DataMember = "ConcertList";
            this._concertGrid.DataSource = this.concertModelBindingSource;
            this._concertGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._concertGrid.Location = new System.Drawing.Point(0, 0);
            this._concertGrid.MultiSelect = false;
            this._concertGrid.Name = "_concertGrid";
            this._concertGrid.ReadOnly = true;
            this._concertGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._concertGrid.Size = new System.Drawing.Size(362, 309);
            this._concertGrid.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this._newButton);
            this.panel6.Controls.Add(this._deletePlaylistButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 309);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(362, 46);
            this.panel6.TabIndex = 5;
            // 
            // _newButton
            // 
            this._newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._newButton.Location = new System.Drawing.Point(3, 4);
            this._newButton.Name = "_newButton";
            this._newButton.Size = new System.Drawing.Size(75, 37);
            this._newButton.TabIndex = 0;
            this._newButton.Text = "New";
            this._newButton.UseVisualStyleBackColor = true;
            // 
            // _deletePlaylistButton
            // 
            this._deletePlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._deletePlaylistButton.Location = new System.Drawing.Point(84, 4);
            this._deletePlaylistButton.Name = "_deletePlaylistButton";
            this._deletePlaylistButton.Size = new System.Drawing.Size(75, 37);
            this._deletePlaylistButton.TabIndex = 0;
            this._deletePlaylistButton.Text = "Delete";
            this._deletePlaylistButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.runtimeVariable);
            this.panel2.Controls.Add(this.runtimeLabel);
            this.panel2.Controls.Add(this._title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 64);
            this.panel2.TabIndex = 4;
            // 
            // runtimeVariable
            // 
            this.runtimeVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runtimeVariable.AutoSize = true;
            this.runtimeVariable.Location = new System.Drawing.Point(656, 50);
            this.runtimeVariable.Name = "runtimeVariable";
            this.runtimeVariable.Size = new System.Drawing.Size(0, 13);
            this.runtimeVariable.TabIndex = 2;
            // 
            // runtimeLabel
            // 
            this.runtimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runtimeLabel.AutoSize = true;
            this.runtimeLabel.Location = new System.Drawing.Point(607, 50);
            this.runtimeLabel.Name = "runtimeLabel";
            this.runtimeLabel.Size = new System.Drawing.Size(49, 13);
            this.runtimeLabel.TabIndex = 1;
            this.runtimeLabel.Text = "Runtime:";
            // 
            // _title
            // 
            this._title.Dock = System.Windows.Forms.DockStyle.Fill;
            this._title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._title.Location = new System.Drawing.Point(0, 0);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(790, 64);
            this._title.TabIndex = 0;
            this._title.Text = "Concerts";
            this._title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // concertIdDataGridViewTextBoxColumn
            // 
            this.concertIdDataGridViewTextBoxColumn.DataPropertyName = "ConcertId";
            this.concertIdDataGridViewTextBoxColumn.HeaderText = "ConcertId";
            this.concertIdDataGridViewTextBoxColumn.Name = "concertIdDataGridViewTextBoxColumn";
            this.concertIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.concertIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // concertNameDataGridViewTextBoxColumn
            // 
            this.concertNameDataGridViewTextBoxColumn.DataPropertyName = "ConcertName";
            this.concertNameDataGridViewTextBoxColumn.HeaderText = "Concert Name";
            this.concertNameDataGridViewTextBoxColumn.Name = "concertNameDataGridViewTextBoxColumn";
            this.concertNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.concertNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artistIdDataGridViewTextBoxColumn
            // 
            this.artistIdDataGridViewTextBoxColumn.DataPropertyName = "ArtistId";
            this.artistIdDataGridViewTextBoxColumn.HeaderText = "ArtistId";
            this.artistIdDataGridViewTextBoxColumn.Name = "artistIdDataGridViewTextBoxColumn";
            this.artistIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.artistIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            this.artistNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.artistNameDataGridViewTextBoxColumn.Width = 360;
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
            this.songNameDataGridViewTextBoxColumn.Width = 230;
            // 
            // ArtistString
            // 
            this.ArtistString.DataPropertyName = "ArtistString";
            this.ArtistString.HeaderText = "Artist";
            this.ArtistString.Name = "ArtistString";
            this.ArtistString.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthDataGridViewTextBoxColumn.Width = 130;
            // 
            // ConcertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ConcertForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._songGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertModelBindingSource)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._artistGrid)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._concertGrid)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _songGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button _deleteSongButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView _concertGrid;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button _newButton;
        private System.Windows.Forms.Button _deletePlaylistButton;
        private System.Windows.Forms.BindingSource concertModelBindingSource;
        private System.Windows.Forms.Label runtimeLabel;
        private System.Windows.Forms.Label runtimeVariable;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView _artistGrid;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistString;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}
