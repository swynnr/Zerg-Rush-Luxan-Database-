using MusicApplication.Data;
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
    public partial class SearchResultsForm : BaseView
    {
        private SearchArtistModel _artistModel;
        private SearchAlbumModel _albumModel;
        private SearchSongModel _songModel;

        public SearchResultsForm()
        {
            InitializeComponent();
            _artistModel = new SearchArtistModel();
            _albumModel = new SearchAlbumModel();
            _songModel = new SearchSongModel();
            albumSearchBindingSource.DataSource = _albumModel.SearchResultsList;
            artistSearchBindingSource.DataSource = _artistModel.SearchResultsList;
            songSearchBindingSource.DataSource = _songModel.SearchResultsList;
        }

        public override void Open<T>(T item)
        {
            var searchTerm = item as SearchQuery;

            if (searchTerm.EntityType == typeof(Artist))
            {
                _artistModel.GetItems(searchTerm);
                _artistGrid.Visible = true;
                _albumGrid.Visible = false;
                _songGrid.Visible = false;
                return;
            }
            if (searchTerm.EntityType == typeof(Album))
            {
                _albumModel.GetItems(searchTerm);
                _artistGrid.Visible = false;
                _albumGrid.Visible = true;
                _songGrid.Visible = false;
                return;
            }
            if (searchTerm.EntityType == typeof(Song))
            {
                _songModel.GetItems(searchTerm);
                _artistGrid.Visible = false;
                _albumGrid.Visible = false;
                _songGrid.Visible = true;
                return;
            }
        }
    }
}
