﻿using MusicApplication.Data;
using QueryManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApplication
{
    public partial class MainForm : Form
    {
        private SearchResultsForm _searchResultsForm;
        private ArtistForm _artistForm;
        private AlbumForm _albumForm;
        private ConcertForm _concertForm;
        private PlaylistForm _playlistForm;

        public MainForm(Query queryManager)
        {
            InitializeComponent();

            _searchResultsForm = new SearchResultsForm(queryManager);
            _artistForm = new ArtistForm(queryManager);
            _albumForm = new AlbumForm(queryManager);
            _concertForm = new ConcertForm(queryManager);
            _playlistForm = new PlaylistForm(queryManager);
        }

        public void DisplayObject(Artist artist)
        { 
            SetVisibleForm(_artistForm);
            _artistForm.Open(artist);
        }

        public void DisplayObject(Album album)
        {
            SetVisibleForm(_albumForm);
            _albumForm.Open(album);
        }

        public void DisplayObject(Playlist playlist)
        {
            tabControl.SelectedIndex = 1;
            _playlistForm.Open(playlist);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetUpControls();
            PopulateComboBox();
            BindEvents();
            
            Search(null, null);
        }

        private void SetUpControls()
        {
            _searchResultsForm.Frame = this;
            _artistForm.Frame = this;
            _albumForm.Frame = this;

            _searchResultsForm.Dock = DockStyle.Fill;
            _artistForm.Dock = DockStyle.Fill;
            _albumForm.Dock = DockStyle.Fill;
            _playlistForm.Dock = DockStyle.Fill;
            _concertForm.Dock = DockStyle.Fill;

            _searchResultsForm.Visible = false;
            _artistForm.Visible = false;
            _albumForm.Visible = false;

            _contentPanel.Controls.Add(_searchResultsForm);
            _contentPanel.Controls.Add(_artistForm);
            _contentPanel.Controls.Add(_albumForm);
            _playlistTab.Controls.Add(_playlistForm);
            _concertTab.Controls.Add(_concertForm);

            SetVisibleForm(_searchResultsForm);
        }

        private void PopulateComboBox()
        {
            _typeSelectorCombo.Items.Add(new ComboBoxItem("Artist", typeof(Artist)));
            _typeSelectorCombo.Items.Add(new ComboBoxItem("Album", typeof(Album)));
            _typeSelectorCombo.Items.Add(new ComboBoxItem("Song", typeof(Song)));
            _typeSelectorCombo.Items.Add(new ComboBoxItem("Playlist", typeof(Playlist)));
            _typeSelectorCombo.SelectedIndex = 0;
        }

        private void SetVisibleForm(Component visibleForm)
        {
            _searchResultsForm.Visible = _searchResultsForm == visibleForm;
            _artistForm.Visible = _artistForm == visibleForm;
            _albumForm.Visible = _albumForm == visibleForm;
        }

        private void BindEvents()
        {
            _searchButton.Click += Search;
        }

        private void Search(object sender, EventArgs e)
        {
            SetVisibleForm(_searchResultsForm);
            _searchResultsForm.Open(new SearchQuery(_searchTextBox.Text, ((ComboBoxItem)_typeSelectorCombo.SelectedItem).Value as Type));
        }
    }
}
