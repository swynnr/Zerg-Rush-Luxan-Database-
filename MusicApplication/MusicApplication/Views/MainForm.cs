﻿using MusicApplication.Data;
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

        public MainForm()
        {
            InitializeComponent();

            _searchResultsForm = new SearchResultsForm();
            _artistForm = new ArtistForm();
            _albumForm = new AlbumForm();
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
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetUpControls();
            BindEvents();
        }

        private void SetUpControls()
        {
            _searchResultsForm.Frame = this;
            _artistForm.Frame = this;
            _albumForm.Frame = this;

            _searchResultsForm.Dock = DockStyle.Fill;
            _artistForm.Dock = DockStyle.Fill;
            _albumForm.Dock = DockStyle.Fill;

            _searchResultsForm.Visible = false;
            _artistForm.Visible = false;
            _albumForm.Visible = false;

            _contentPanel.Controls.Add(_searchResultsForm);
            _contentPanel.Controls.Add(_artistForm);
            _contentPanel.Controls.Add(_albumForm);

            SetVisibleForm(_albumForm);
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
            _searchResultsForm.Open(new SearchQuery(_searchButton.Text, typeof(Album))); // TODO: Change to use the selected combobox option
        }
    }
}